using Costs.Entities;
using Costs.Forms.Main.InternalViews;
using Costs.Views.EventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costs.Views.Parts
{

	/*
	 * >>>
	 * 01-07-2020 16:03
	 * Основная цель этого деления - разделить логическую нагрузку на компоненты.
	 *	За сетку отвечает презентер сетки
	 *	За директории отвечает презентер директорий
	 *	Но они должны коммуницировать. Или отдавать доклады (запросы) вышестоящему органу.
	 * 
	 * 
	 * 
	 */
	public interface IPurchasesViewPart
	{
		void SetPurchases(IEnumerable<Purchase> ppList);
		void SetPurchasesAmount(decimal amount);

		event Action<ProductType> CommandProductTypeDropped;
		event Action<Purchase> CommandEditPurchase;
		event Action<Purchase> CommandDeletePurchase;
	}
}
