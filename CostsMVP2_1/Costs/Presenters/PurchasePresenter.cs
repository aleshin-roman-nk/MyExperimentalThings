using Costs.Entities;
using Costs.Forms;
using Costs.Models;
using Costs.Presenters.Views;
using System.Collections.Generic;
using Costs.DlgService;
using Costs.Presenters.Views.EventArgs;
using Costs.BL.Models;

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
	public class EditPurchasePresenter
	{
		IPurchaseView view;
		DirectoriesModel directoryModel;

		public EditPurchasePresenter(IPurchaseView v)
		{
			view = v;
			directoryModel = new DirectoriesModel();
		}

        public EditPurchasePresenter Run(Purchase editArg)
		{
			view.SetPurchase(editArg);
			view.SetDirectoryName(directoryModel.GetDirectory(editArg.DirectoryID).Name);
			return this;
		}
		public Purchase Result()
		{
			return view.GetPurchase();
		}
	}
}