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

			_editDocumentView.CategoriesView.CommandCreateCategory += CategoriesView_CommandCreateCategory;
			_editDocumentView.CategoriesView.CommandCreateProductType += CategoriesView_CommandCreateProductType;
			_editDocumentView.CategoriesView.CommandDeleteCategory += CategoriesView_CommandDeleteCategory;
			_editDocumentView.CategoriesView.CommandDeleteProductType += CategoriesView_CommandDeleteProductType;
			_editDocumentView.CategoriesView.CommandAddPointToDoc += CategoriesView_AddPointToDoc;

			_editDocumentView.DirectoriesView.CommandCreateDirectory += DirectoriesView_CommandCreateDirectory;
			_editDocumentView.DirectoriesView.CommandPurchaseDropped += DirectoriesView_CommandPurchaseDropped;

			_editDocumentView.PurchasesView.CommandProductTypeDropped += PurchasesView_CommandProductTypeDropped;
			_editDocumentView.PurchasesView.CommandDeletePurchase += PurchasesView_CommandDeletePurchase;
			_editDocumentView.ShopNameRequested += _editDocumentView_ShopNameRequested;
			_editDocumentView.PurchasesView.CommandEditPurchase += PurchasesView_CommandEditPurchase;
		}

		private void PurchasesView_CommandEditPurchase(Purchase obj)
		{
			IEditPurchaseView purchaseView = _factory.CreatePurchaseView();
			purchaseView.SetPurchase(obj);
			purchaseView.SetDirectoryName(obj.DirName);

			var res = purchaseView.GetResult();

			if (res.Answer == ResponseCode.Ok)
			{
				obj.Accept(res.Result);
				obj.Save();
				//model.PayDocumentModel.AddPosition(obj);
				updatePurchases(model.PayDocumentModel.Document.Purchases, model.PayDocumentModel.Document.Amount);
			}
		}

		private void CategoriesView_AddPointToDoc(ProductType obj)
		{
			PurchasesView_CommandProductTypeDropped(obj);
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

		private void PurchasesView_CommandDeletePurchase(Purchase obj)
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

		private void DirectoriesView_CommandCreateDirectory(Directory obj)
		{
			string name = _dlgView.InputText("", $"Родительская директория :{obj.Name}\r\nВведите имя новой директории");

			if (!string.IsNullOrEmpty(name))
			{
				obj.CreateChild(name).Save();
				_editDocumentView.DirectoriesView.SetDirectories(model.DirectoriesModel.GetDirectories());
			}
		}

		private void DirectoriesView_CommandPurchaseDropped(PurchaseDroppedEventArg obj)
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
		private void PurchasesView_CommandProductTypeDropped(ProductType e)
		{
			Purchase product = EntityFactory.CreatePurchase();

			if (e != null) product.Name = e.Name;

			// >>> 03-03-2021 00:09
			// Постоянно зыбавю разбрасывать по категориям. Поэтому убираю автоматическое присвоение директории.
			//_editDocumentView.DirectoriesView.Current.Attach(product, model.DirectoriesModel);

			//product.DirectoryID = _editDocumentView.DirectoriesView.Current.ID;
			//product.DirName = model.DirectoriesModel.GetDirFullName(_editDocumentView.DirectoriesView.Current.ID);

			IEditPurchaseView purchaseView = _factory.CreatePurchaseView();
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

		private void CategoriesView_CommandDeleteProductType(ProductType obj)
		{
			if (_dlgView.UserAnsweredYes($"Тип продукта '{obj.Name}' будет удален. Подтвердите."))
			{
				model.ProductTypeModel.DeleteProductType(obj);
				_editDocumentView.CategoriesView.SetProductTypes(model.ProductTypeModel.GetProductTypes(_editDocumentView.CategoriesView.CurrentCategory));
			}
		}

		private void CategoriesView_CommandDeleteCategory(Category obj)
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
		private void CategoriesView_CommandCreateProductType(Category obj)
		{
			var res = _dlgView.InputText("", "Создание нового типа продукта\r\nВведите имя типа");
			if (string.IsNullOrWhiteSpace(res)) return;

			ProductType pt = new ProductType { Name = res, CategoryId = obj.Id };
			model.ProductTypeModel.SaveProductType(pt);
			_editDocumentView.CategoriesView.SetProductTypes(model.ProductTypeModel.GetProductTypes(obj));
		}

		private void CategoriesView_CommandCreateCategory()
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

			updateDocument(model.PayDocumentModel.Document);

			_editDocumentView.FormClosing1 += (s, p) =>
			{
				p.Close = true;
				if (model.PayDocumentModel.Document.HasUnattachedPosition())
				{
					Messages.ShowError("Документ имеет висящие позиции. Необходимо разместить по директориям", "Позиции не привязаны!");
					p.Close = false;
				}
			};

			IInputDateTimeView inputDateTimeForm = new InputDateTimeForm();
			inputDateTimeForm.Go();
			_editDocumentView.CurrentDateTime = inputDateTimeForm.UserDateTime;

			var res = _editDocumentView.GetResult();

			if(res.Answer == ResponseCode.Ok)
			{
				model.PayDocumentModel.Document.DateTime = _editDocumentView.CurrentDateTime;
				model.PayDocumentModel.Document.Shop = _editDocumentView.Shop;
				model.PayDocumentModel.Save();
			}
		}
	}
}
