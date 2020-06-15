using Costs.BL.Domain.Entities;
using Costs.BL.Models;
using Costs.Models;
using Costs.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costs.Presenters
{
	public class ViewDocumentPresenter
	{
		IViewDocument view;
		ViewDocumentModel model;

		public ViewDocumentPresenter(IViewDocument v)
		{
			view = v;
			model = new ViewDocumentModel();

			view.BtnCreateCategory += View_BtnCreateCategory;
			view.BtnDeleteCategory += View_BtnDeleteCategory;
			view.CategoriesRequired += View_CategoriesRequired;

			view.BtnCreateDirectory += View_BtnCreateDirectory;
			view.BtnDeleteDirectory += View_BtnDeleteDirectory;
			view.BtnRenameDirectory += View_BtnRenameDirectory;
			view.MoveDirectory += View_MoveDirectory;

			view.BtnCreateProductType += View_BtnCreateProductType;
			view.BtnDeleteProductType += View_BtnDeleteProductType;
			view.ProductTypesRequired += View_ProductTypesRequired;

			view.CreatePurchase += View_CreatePurchase;
			view.DeletePurchase += View_DeletePurchase;
			view.EditPurchase += View_EditPurchase;
			view.MovePurchase += View_MovePurchase;
			view.ValuesChanged += View_ValuesChanged;
		}

		public PaymentDoc Run(PaymentDoc doc)
		{
			//view.SetCategories(model.ProductTypeModel.Categories);
			view.SetDirectories(model.DirectoryModel.GetDirectories());
			view.SetDoc(doc);

			//if (!view.ShowForm()) return null;
			view.ShowForm();

			return view.GetResult();
		}

		private void View_ValuesChanged(DateTime arg1, Entities.Directory arg2)
		{
			throw new NotImplementedException();
		}

		private void View_ProductTypesRequired(Domain.Entities.Category obj)
		{
			throw new NotImplementedException();
		}

		private void View_MovePurchase(Entities.Purchase arg1, Entities.Directory arg2)
		{
			throw new NotImplementedException();
		}

		private void View_MoveDirectory(Entities.Directory arg1, Entities.Directory arg2)
		{
			throw new NotImplementedException();
		}

		private void View_EditPurchase(Entities.Purchase obj)
		{
			throw new NotImplementedException();
		}

		private void View_DeletePurchase(Entities.Purchase obj)
		{
			throw new NotImplementedException();
		}

		private void View_CreatePurchase(Entities.ProductType arg1, DateTime arg2)
		{
			throw new NotImplementedException();
		}

		private void View_CategoriesRequired()
		{
			throw new NotImplementedException();
		}

		private void View_BtnRenameDirectory(Entities.Directory obj)
		{
			throw new NotImplementedException();
		}

		private void View_BtnDeleteProductType(Entities.ProductType obj)
		{
			throw new NotImplementedException();
		}

		private void View_BtnDeleteDirectory(Entities.Directory obj)
		{
			throw new NotImplementedException();
		}

		private void View_BtnDeleteCategory(Domain.Entities.Category obj)
		{
			throw new NotImplementedException();
		}

		private void View_BtnCreateProductType(string arg1, Domain.Entities.Category arg2)
		{
			throw new NotImplementedException();
		}

		private void View_BtnCreateDirectory(Entities.Directory obj)
		{
			throw new NotImplementedException();
		}

		private void View_BtnCreateCategory(string obj)
		{
			throw new NotImplementedException();
		}

		void reloadData()
		{

		}
	}
}
