using Costs.BL.Domain.Entities;
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
		IEditDocumentView view;
		IDialogMessages _dlgView;
		EditDocumentModel model;

		public EditDocumentPresenter(IEditDocumentView v, IDialogMessages dialog)
		{
			view = v;
			_dlgView = dialog;
			model = new EditDocumentModel();

			view.CategoriesView.UpdateCategories += () => 
				view.CategoriesView.SetCategories(model.CategoriesModel.Categories);
			view.CategoriesView.UpdateProductTypes += (e) => 
				view.CategoriesView.SetProductTypes(model.ProductTypeModel.GetProductTypes(e));

			view.CategoriesView.CreateCategoryCmd += CategoriesView_CreateCategoryCmd;
			view.CategoriesView.CreateProductTypeCmd += CategoriesView_CreateProductTypeCmd;
			view.CategoriesView.DeleteCategoryCmd += CategoriesView_DeleteCategoryCmd;
			view.CategoriesView.DeleteProductTypeCmd += CategoriesView_DeleteProductTypeCmd;

			view.DirectoriesView.CreateDirectoryCmd += DirectoriesView_CreateDirectoryCmd;
			view.DirectoriesView.PurchaseDroppedCmd += DirectoriesView_PurchaseDroppedCmd;

			view.PurchasesView.ProductTypeDropped += PurchasesView_ProductTypeDropped;
			view.PurchasesView.DeletePurchaseCmd += PurchasesView_DeletePurchaseCmd;
		}

		private void PurchasesView_DeletePurchaseCmd(Purchase obj)
		{
			if (obj == null) return;

			if (!_dlgView.UserAnsweredYes($"Удалить позицию {obj.Name}?")) return;

			model.PayDocumentModel.DeletePosition(obj);
			view.PurchasesView.SetPurchases(model.PayDocumentModel.Document.Purchases);
		}

		private void DirectoriesView_CreateDirectoryCmd(Directory obj)
		{
			string name = _dlgView.InputText("", $"Родительская директория :{obj.Name}\r\nВведите имя новой директории");

			if (!string.IsNullOrEmpty(name))
			{
				obj.CreateChild(name).Save();
				view.DirectoriesView.SetDirectories(model.DirectoriesModel.GetDirectories());
			}
		}

		private void DirectoriesView_PurchaseDroppedCmd(PurchaseDroppedEventArg obj)
		{
			// необязательно записывать в БД и перезагружать все сущности
			//	можно дублировать операцию - изменить в памяти и отправить фиксацию в бд без перезагрузки картины из бд

			obj.Desc.Attach(obj.Dropped);
			view.PurchasesView.SetPurchases(model.PayDocumentModel.Document.Purchases);


			//obj.Dropped.Save();Сохраняет только при выходе в методе Run
		}

		private void PurchasesView_ProductTypeDropped(ProductType e)
		{
			Purchase product = EntityFactory.CreatePurchase(view.CurrentDateTime);

			if (e != null) product.Name = e.Name;
			product.DirectoryID = view.DirectoriesView.Current.ID;
			product.DirName = view.DirectoriesView.Current.Name;

			IPurchaseView purchaseView = FormsFactory.CreatePurchaseView();
			purchaseView.SetPurchase(product);
			purchaseView.SetDirectoryName(product.DirName);

			var res = purchaseView.GetResult();

			if (res.Answer == ResponseCode.Ok)
			{
				product.Accept(res.Result);

				model.PayDocumentModel.AddPosition(product);
				view.PurchasesView.SetPurchases(model.PayDocumentModel.Document.Purchases);
				view.PurchasesView.SetPurchasesAmount(model.PayDocumentModel.Document.Amount);
			}
		}

		private void CategoriesView_DeleteProductTypeCmd(ProductType obj)
		{
			if (_dlgView.UserAnsweredYes($"Тип продукта '{obj.Name}' будет удален. Подтвердите."))
			{
				model.ProductTypeModel.DeleteProductType(obj);
				view.CategoriesView.SetProductTypes(model.ProductTypeModel.GetProductTypes(view.CategoriesView.CurrentCategory));
			}
		}

		private void CategoriesView_DeleteCategoryCmd(Category obj)
		{
			if (_dlgView.UserAnsweredYes($"Категория {obj.Name} будет удалена со всеми вложенными элементами. Подтвердите."))
			{
				model.CategoriesModel.Delete(obj);
				view.CategoriesView.SetCategories(model.CategoriesModel.Categories);
			}
		}

		private void CategoriesView_CreateProductTypeCmd(Category obj)
		{
			var res = _dlgView.InputText("", "Создание нового типа продукта\r\nВведите имя типа");
			if (string.IsNullOrWhiteSpace(res)) return;

			ProductType pt = new ProductType { Name = res, CategoryId = obj.Id };
			model.ProductTypeModel.SaveProductType(pt);
			view.CategoriesView.SetProductTypes(model.ProductTypeModel.GetProductTypes(obj));
		}

		private void CategoriesView_CreateCategoryCmd()
		{
			var res = _dlgView.InputText("", "Создание новой категории\r\nВведите имя категории");

			if (string.IsNullOrWhiteSpace(res)) return;

			Category cat = new Category { Name = res };
			model.CategoriesModel.Save(cat);
			view.CategoriesView.SetCategories(model.CategoriesModel.Categories);
		}

		/*
		 * >>> 03-07-2020 19:40
		 * Мне нужно решить, на каком этапе фиксировать в БД изменения сущности.
		 *	Хотя возможно можно и здесь записать результат.
		 * 
		 * 
		 * 
		 */

		// Entry point
		public void Run(PaymentDoc doc)
		{
			/*
			 * >>> 03-07-2020 12:21
			 * Сюда передавать объект в памяти. Никаких записей в БД
			 *		Все добавления в памяти. Только при завершении работы с документом, по закрытию зеленой кнопкой произвести необходимые записи в БД
			 *			
			 * 
			 * 
			 */

			model.PayDocumentModel = new PayDocumentModel(doc);

			view.CategoriesView.SetCategories(model.CategoriesModel.Categories);
			view.DirectoriesView.SetDirectories(model.DirectoriesModel.GetDirectories());

			view.PurchasesView.SetPurchases(model.PayDocumentModel.Document.Purchases);

			var res = view.GetResult();

			if(res.Answer == ResponseCode.Ok)
			{
				model.PayDocumentModel.Document.DateTime = view.CurrentDateTime;
				model.PayDocumentModel.Document.Shop = view.Shop;
				model.PayDocumentModel.Save();
			}
		}

		void reloadData()
		{

		}
	}
}
