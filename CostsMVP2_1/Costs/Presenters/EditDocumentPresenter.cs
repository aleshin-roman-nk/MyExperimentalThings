using Costs.BL.Domain.Entities;
using Costs.BL.Entities;
using Costs.BL.Models;
using Costs.DlgService;
using Costs.Domain.Entities;
using Costs.Entities;
using Costs.Forms;
using Costs.Models;
using Costs.Presenters.Views;
using Costs.Views;
using Costs.Views.EventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costs.Presenters
{
	/// <summary>
	/// Работа с сущностью PaymentDoc.
	/// Запись в БД не производится
	/// </summary>
	public class EditDocumentPresenter
	{
		IFormsFactory _factory;
		EditDocumentModel model;

		IEditDocumentView _editDocumentView;
		IDialogMessages _dlgView;

		public EditDocumentPresenter(IFormsFactory f)
		{
			_factory = f;

			model = new EditDocumentModel();

			_editDocumentView = _factory.CreateEditDocumentView();
			_dlgView = _factory.CreateDialogMessages();

			_editDocumentView.CategoriesView.UpdateCategories += () =>
				_editDocumentView.CategoriesView.SetCategories(model.CategoriesModel.Categories);
			_editDocumentView.CategoriesView.UpdateProductTypes += (e) =>
				_editDocumentView.CategoriesView.SetProductTypes(model.ProductTypeModel.GetProductTypes(e));

			_editDocumentView.CategoriesView.CreateCategoryCmd += CategoriesView_CreateCategoryCmd;
			_editDocumentView.CategoriesView.CreateProductTypeCmd += CategoriesView_CreateProductTypeCmd;
			_editDocumentView.CategoriesView.DeleteCategoryCmd += CategoriesView_DeleteCategoryCmd;
			_editDocumentView.CategoriesView.DeleteProductTypeCmd += CategoriesView_DeleteProductTypeCmd;

			_editDocumentView.DirectoriesView.CreateDirectoryCmd += DirectoriesView_CreateDirectoryCmd;
			_editDocumentView.DirectoriesView.PurchaseDroppedCmd += DirectoriesView_PurchaseDroppedCmd;

			_editDocumentView.PurchasesView.ProductTypeDropped += PurchasesView_ProductTypeDropped;
			_editDocumentView.PurchasesView.DeletePurchaseCmd += PurchasesView_DeletePurchaseCmd;
			_editDocumentView.ShopNameRequested += _editDocumentView_ShopNameRequested;
		}

		private void _editDocumentView_ShopNameRequested(object sender, EventArgs e)
		{
			var f = _factory.CreateShopsView();
			ShopsModel shopsModel = new ShopsModel();

			f.AddShop += (s, ev) =>
			{
				//var sss = _factory.CreateDialogMessages().InputText("", "Введите название нового магазина");
				//if (sss == null) return;
				if (string.IsNullOrWhiteSpace(ev)) return;
				shopsModel.Save(new Shop { Name = ev });
				f.SetShops(shopsModel.Get());
			};

			f.DeleteShop += (s, ev) =>
			{
				if (ev == null) return;
				if(_factory.CreateDialogMessages().UserAnsweredYes($"Подтвердите удаление магазина {ev.Name}."))
				{
					shopsModel.Delete(ev);
					f.SetShops(shopsModel.Get());
				}
			};

			f.SetShops(shopsModel.Get());

			var res = f.GetResult();

			if(res.Answer == ResponseCode.Ok)
				_editDocumentView.Shop = res.Result;
		}

		private void PurchasesView_DeletePurchaseCmd(Purchase obj)
		{
			if (obj == null) return;

			if (!_dlgView.UserAnsweredYes($"Удалить позицию {obj.Name}?")) return;

			model.PayDocumentModel.DeletePosition(obj);
			updatePurchases(model.PayDocumentModel.Document.Purchases, model.PayDocumentModel.Document.Amount);
		}

		private void updatePurchases(IEnumerable<Purchase> purchases, decimal amount)
		{
			_editDocumentView.PurchasesView.SetPurchases(purchases);
			_editDocumentView.PurchasesView.SetPurchasesAmount(amount);
		}

		private void updateDocument(PaymentDoc doc)
		{
			_editDocumentView.CurrentDateTime = doc.DateTime == default ? DateTime.Now : doc.DateTime;
			_editDocumentView.Shop = doc.Shop;
			_editDocumentView.PurchasesView.SetPurchases(doc.Purchases);
			_editDocumentView.PurchasesView.SetPurchasesAmount(doc.Amount);
		}

		private void DirectoriesView_CreateDirectoryCmd(Directory obj)
		{
			string name = _dlgView.InputText("", $"Родительская директория :{obj.Name}\r\nВведите имя новой директории");

			if (!string.IsNullOrEmpty(name))
			{
				obj.CreateChild(name).Save();
				_editDocumentView.DirectoriesView.SetDirectories(model.DirectoriesModel.GetDirectories());
			}
		}

		private void DirectoriesView_PurchaseDroppedCmd(PurchaseDroppedEventArg obj)
		{
			// необязательно записывать в БД и перезагружать все сущности
			//	можно дублировать операцию - изменить в памяти и отправить фиксацию в бд без перезагрузки картины из бд

			obj.Desc.Attach(obj.Dropped, model.DirectoriesModel);
			updatePurchases(model.PayDocumentModel.Document.Purchases, model.PayDocumentModel.Document.Amount);
			//_editDocumentView.PurchasesView.SetPurchases(model.PayDocumentModel.Document.Purchases);


			//obj.Dropped.Save();Сохраняет только при выходе в методе Run
		}

		/// <summary>
		/// Добавление позиции в документ без записи в БД
		/// </summary>
		/// <param name="e"></param>
		private void PurchasesView_ProductTypeDropped(ProductType e)
		{
			Purchase product = EntityFactory.CreatePurchase();

			if (e != null) product.Name = e.Name;

			_editDocumentView.DirectoriesView.Current.Attach(product, model.DirectoriesModel);

			//product.DirectoryID = _editDocumentView.DirectoriesView.Current.ID;
			//product.DirName = model.DirectoriesModel.GetDirFullName(_editDocumentView.DirectoriesView.Current.ID);

			IPurchaseView purchaseView = _factory.CreatePurchaseView();
			purchaseView.SetPurchase(product);
			purchaseView.SetDirectoryName(product.DirName);

			var res = purchaseView.GetResult();

			if (res.Answer == ResponseCode.Ok)
			{
				product.Accept(res.Result);

				model.PayDocumentModel.AddPosition(product);
				updatePurchases(model.PayDocumentModel.Document.Purchases, model.PayDocumentModel.Document.Amount);
			}
		}

		private void CategoriesView_DeleteProductTypeCmd(ProductType obj)
		{
			if (_dlgView.UserAnsweredYes($"Тип продукта '{obj.Name}' будет удален. Подтвердите."))
			{
				model.ProductTypeModel.DeleteProductType(obj);
				_editDocumentView.CategoriesView.SetProductTypes(model.ProductTypeModel.GetProductTypes(_editDocumentView.CategoriesView.CurrentCategory));
			}
		}

		private void CategoriesView_DeleteCategoryCmd(Category obj)
		{
			if (_dlgView.UserAnsweredYes($"Категория {obj.Name} будет удалена со всеми вложенными элементами. Подтвердите."))
			{
				model.CategoriesModel.Delete(obj);
				_editDocumentView.CategoriesView.SetCategories(model.CategoriesModel.Categories);
			}
		}

		// >>> 18-07-2020 14:13 
		// !!! !!! !!!
		// Это можно отдать презентеру этого контрола
		// Так много раз приходится дублировать код (категории, типы продуктов)
		// Ввобще прорисовать схему взаимодействия всех модулей (презентеров, вьюшек, моделей.)
		// Одна стрелка означает кто к кому обращается.
		private void CategoriesView_CreateProductTypeCmd(Category obj)
		{
			var res = _dlgView.InputText("", "Создание нового типа продукта\r\nВведите имя типа");
			if (string.IsNullOrWhiteSpace(res)) return;

			ProductType pt = new ProductType { Name = res, CategoryId = obj.Id };
			model.ProductTypeModel.SaveProductType(pt);
			_editDocumentView.CategoriesView.SetProductTypes(model.ProductTypeModel.GetProductTypes(obj));
		}

		private void CategoriesView_CreateCategoryCmd()
		{
			var res = _dlgView.InputText("", "Создание новой категории\r\nВведите имя категории");

			if (string.IsNullOrWhiteSpace(res)) return;

			Category cat = new Category { Name = res };
			model.CategoriesModel.Save(cat);
			_editDocumentView.CategoriesView.SetCategories(model.CategoriesModel.Categories);
		}

		// Entry point
		public void Run(PaymentDoc doc)
		{
			/*
			 * >>> 03-07-2020 12:21
			 * Сюда передавать объект в памяти. Никаких записей в БД
			 *		Все добавления в памяти. Только при завершении работы с документом, по закрытию зеленой кнопкой произвести необходимые записи в БД
			 */

			model.PayDocumentModel = new PayDocumentModel(doc);

			_editDocumentView.CategoriesView.SetCategories(model.CategoriesModel.Categories);
			_editDocumentView.DirectoriesView.SetDirectories(model.DirectoriesModel.GetDirectories());

			//_editDocumentView.PurchasesView.SetPurchases(model.PayDocumentModel.Document.Purchases);
			//_editDocumentView.CurrentDateTime = doc.DateTime == default ? DateTime.Now : doc.DateTime;
			//_editDocumentView.Shop = model.PayDocumentModel.Document.Shop;

			updateDocument(model.PayDocumentModel.Document);

			var res = _editDocumentView.GetResult();

			if(res.Answer == ResponseCode.Ok)
			{
				// !!! Не нравится мне такое неавное применение. Где я должен видеть о том, как применяются измененные покупки?
				model.PayDocumentModel.Document.DateTime = _editDocumentView.CurrentDateTime;
				model.PayDocumentModel.Document.Shop = _editDocumentView.Shop;
				model.PayDocumentModel.Save();
			}
		}
	}
}
