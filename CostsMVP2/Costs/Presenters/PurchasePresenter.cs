using Costs.Entities;
using Costs.Forms;
using Costs.Models;
using Costs.Presenters.Views;
using Costs.Entities.Extension;
using System.Collections.Generic;
using Costs.DlgService;
using Costs.Presenters.Views.EventArgs;

/*
 * Разделение решения на проекты.
 * 
 * Проект presenter - model - iview
 * фабрика presenter - iview
 * 
 * * * * * * * * * * *
 * UI проект: UI
 * включение проекта presenter - model - iview
 * реализация IView
 * фабрика presenter - iview
 * 
 * 
 */

namespace Costs.Presenters
{
	/*
	 * >>>
	 * 24-03-2020 3-28
	 * В принципе имеет право на существование отдельный презентер... хотя бы я как то по другому назвал этот класс
	 *		так вот, когда логика слишком загружена, можно основной презентер разбить на части.
	 * 
	 */
	public class PurchasePresenter
	{
		IPurchaseView view;
		PurchaseModel model;// Время жизни совпадает с временем жизни PurchasePresenter

		public PurchasePresenter(IPurchaseView v)
		{
			view = v;
			model = new PurchaseModel();
			
			view.RequestSampleProductList += View_RequestSampleProductList;
		}

        public PurchasePresenter Go(Purchase editArg)
		{
			view.SetPurchase(editArg);
			view.SetDirectoryName(model.GetDirectory(editArg.DirectoryID).Name);
			return this;
		}
		public Purchase Result()
		{
			return view.GetPurchase();
		}
		private void View_RequestSampleProductList(string name, List<ProductType> spList)
		{
			spList.Clear();
			spList.AddRange(model.GetProductTypesByName(name));
		}
	}
}