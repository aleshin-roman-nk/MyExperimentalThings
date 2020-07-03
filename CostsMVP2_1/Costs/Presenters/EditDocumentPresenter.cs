﻿using Costs.BL.Domain.Entities;
using Costs.BL.Models;
using Costs.Domain.Entities;
using Costs.Entities;
using Costs.Forms;
using Costs.Models;
using Costs.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costs.Presenters
{
	public class EditDocumentPresenter
	{
		IEditDocument view;
		IDialogMessages _dlgView;
		ViewDocumentModel model;

		PaymentDoc document = null;

		public EditDocumentPresenter(IEditDocument v, IDialogMessages dialog)
		{
			view = v;
			_dlgView = dialog;
			model = new ViewDocumentModel();

			view.CategoriesView.UpdateCategories += () => 
				view.CategoriesView.SetCategories(model.CategoriesModel.Categories);
			view.CategoriesView.UpdateProductTypes += (e) => 
				view.CategoriesView.SetProductTypes(model.ProductTypeModel.GetProductTypes(e));

			view.CategoriesView.CreateCategoryCmd += CategoriesView_CreateCategoryCmd;
			view.CategoriesView.CreateProductTypeCmd += CategoriesView_CreateProductTypeCmd;
			view.CategoriesView.DeleteCategoryCmd += CategoriesView_DeleteCategoryCmd;
			view.CategoriesView.DeleteProductTypeCmd += CategoriesView_DeleteProductTypeCmd;

			view.PurchasesView.ProductTypeDropped += PurchasesView_ProductTypeDropped;
		}

		private void PurchasesView_ProductTypeDropped(ProductType e)
		{
			Purchase product = model.PurchaseModel.Create(view.CurrentDateTime);

			if (e != null) product.Name = e.Name;
			product.DirectoryID = view.DirectoriesView.Current.ID;
			product.Directory = view.DirectoriesView.Current;
			/*
			 * >>> 03-07-2020 12:16
			 * Вообще все Save выполняются по нажатию кнопки сохранить.
			 * 
			 * При редактировании существующего документа перед закрытием произвести его загрузку и синхронизацию позиций,
			 *	то что хранится в БД и то, что осталось после редактирования
			 * 
			 */
			var res = new EditPurchasePresenter(FormsFactory.CreatePurchaseView()).Run(product).Result();

			if (res != null)
			{
				product.Accept(res);
				//product.PaymentDocId = document.Id;
				//model.PurchaseModel.SavePurchase(product);
				model.PayDocumentModel.AddPosition(product);
				view.PurchasesView.SetPurchases(document.Purchases);
				//reloadPurchases(view.CurrentDirectory, view.CurrentDate, view.OneDay);
			}
		}

		private void CategoriesView_DeleteProductTypeCmd(ProductType obj)
		{
			if (_dlgView.UserAnswerYes($"Тип продукта '{obj.Name}' будет удален. Подтвердите."))
			{
				model.ProductTypeModel.DeleteProductType(obj);
				view.CategoriesView.SetProductTypes(model.ProductTypeModel.GetProductTypes(view.CategoriesView.CurrentCategory));
			}
		}

		private void CategoriesView_DeleteCategoryCmd(Category obj)
		{
			if (_dlgView.UserAnswerYes($"Категория {obj.Name} будет удалена со всеми вложенными элементами. Подтвердите."))
			{
				model.CategoriesModel.Delete(obj);
				view.CategoriesView.SetCategories(model.CategoriesModel.Categories);
			}
		}

		private void CategoriesView_CreateProductTypeCmd(Category obj)
		{
			var res = _dlgView.InputText("", "Создание нового типа продукта\n Введите имя типа");
			if (string.IsNullOrWhiteSpace(res)) return;

			ProductType pt = new ProductType { Name = res, CategoryId = obj.Id };
			model.ProductTypeModel.SaveProductType(pt);
			view.CategoriesView.SetProductTypes(model.ProductTypeModel.GetProductTypes(obj));
		}

		private void CategoriesView_CreateCategoryCmd()
		{
			var res = _dlgView.InputText("", "Создание новой категории\n Введите имя категории");

			if (string.IsNullOrWhiteSpace(res)) return;

			Category cat = new Category { Name = res };
			model.CategoriesModel.Save(cat);
			view.CategoriesView.SetCategories(model.CategoriesModel.Categories);
		}

		public void Run(PaymentDoc doc)
		{
			document = doc;

			/*
			 * >>> 03-07-2020 12:21
			 * Сюда передавать объект в памяти. Никаких обращений к БД
			 *		Все добавления в памяти. Только при завершении работы с документом, по закрытию зеленой кнопкой произвести необходимые записи в БД
			 *			
			 * 
			 * 
			 */

			model.PayDocumentModel.SetEntity(document);

			view.CategoriesView.SetCategories(model.CategoriesModel.Categories);
			view.DirectoriesView.SetDirectories(model.DirectoriesModel.GetDirectories());

			view.PurchasesView.SetPurchases(document.Purchases);

			//view.SetDirectories(model.DirectoryModel.GetDirectories());

			//if (!view.ShowForm()) return null;
			if (view.ShowForm().Answer == Answer.Ok)
			{
				model.PayDocumentModel.Save();
			}
		}

		void reloadData()
		{

		}
	}
}