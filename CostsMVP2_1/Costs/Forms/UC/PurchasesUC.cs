using System;
using System.Collections.Generic;
using Costs.Forms.Common;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Costs.Views.Parts;
using Costs.Entities;
using Costs.Views.EventArgs;
using Costs.Forms.Main.InternalViews;


namespace Costs.Forms.UC
{
	public partial class PurchasesUC : UserControl, IPurchasesViewPart
	{
		PurchasesGridHandler purchasesGridHandler;

		public event Action<ProductType> CommandProductTypeDropped;
		public event Action<Purchase> CommandEditPurchase;
		public event Action<Purchase> CommandDeletePurchase;

		// >>> 02-07-2020 01:20 НА СЛЕД РАЗ имея ссылуц на др usercontrol можем создавать событие с полноценными данными
		// Но на самом деле нам может не понадобится создавать событие с полноценными данными. Поэтому можно законфигурировать.
		//	Возможно в этом случае пусть будут ссылки на др usercontrol
		//	Хотя для создания документа изменение даты неактуально.

		/*
		 * >>> 02-07-2020 15:12
		 * Нет, однозначно не нужена здесь связь с компонентом времени.
		 * 
		 */
		//public UcDateView DateController { get; set; }// 

		public PurchasesUC()
		{
			InitializeComponent();

			dgvPurchases.AutoGenerateColumns = false;

			purchasesGridHandler = new PurchasesGridHandler(dgvPurchases);
			purchasesGridHandler.CreatePurchase += (pt) => CommandProductTypeDropped?.Invoke(pt);
			purchasesGridHandler.EditPurchase += (purch) => CommandEditPurchase?.Invoke(purch);
			purchasesGridHandler.DeletePurchase += (purch) => CommandDeletePurchase?.Invoke(purch);
		}
		public void SetPurchases(IEnumerable<Purchase> ppList)
		{
			purchasesGridHandler.SetItems(ppList);
		}

		public void SetPurchasesAmount(decimal amount)
		{
			tbCurrentAmount.Text = $"{amount:c}";
		}

	}
}
