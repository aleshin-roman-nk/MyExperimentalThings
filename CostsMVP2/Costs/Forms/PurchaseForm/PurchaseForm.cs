﻿using Costs.Entities;
using Costs.Presenters.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Costs.Forms.DlgService;
using Costs.Presenters.Views.EventArgs;
using Costs.DlgService;
// Прописывать в начале класса в комментарии четко определенную задачу, которую нужно решить


/*
 * 
 * База имен продуктов нужна для эффективного поиска.
 * 
 * Ввод имени продукта вручную, быстрый поиск фильтрует схожие имена, затем выбрать нужный, или если нету, то добавить в базу новое имя.
 * Добавить категорию имени. Необязательно к использованию, но дает возможность добавить функционал поиска в категориях.
 */

/*
 * Задачи, решаемые этим блоком
 */

// Блок справочник товаров

namespace Costs.Forms
{
	public partial class PurchaseForm : Form, IPurchaseView
	{
		List<ProductType> sampleProducts = new List<ProductType>();
		Purchase purchase = null;

		public PurchaseForm()
		{
			InitializeComponent();
		}

		private void btnShowChoosingSampleProduct_Click(object sender, EventArgs e)
		{
			//List<ProductType> spList = new List<ProductType>();
			//RequestSampleProductList?.Invoke(null, spList);

			//using (ChooseItemForm<ProductType> f = new ChooseItemForm<ProductType>())
			//{
			//	f.FilterTextChanged += (txt) => {
			//		// 1. Запрос на фильтрацию списка
			//		RequestSampleProductList?.Invoke(txt, spList);
			//		// 2. Обновление списка в форме
			//		f.SetList(spList, "Name");
			//	};

			//	f.SetList(spList, "Name");
			//	f.Current = spList.FirstOrDefault(x => x.ID == purchase.ProductTypeID);
			//	f.Location = PointToScreen((sender as Button).Location);
			//	f.StartPosition = FormStartPosition.Manual;

			//	DialogResult result = f.ShowDialog();

			//	if(result == DialogResult.OK)
			//	{
			//		setSampleProductToTextBox(f.Current);
			//		setSampleProductToPurchase();
			//	}
			//}
		}

		#region IPurchaseView

		public void SetDirectoryName(string dirName)
		{
			lbDirectoryName.Text = dirName;
		}

		public event Action<string, List<ProductType>> RequestSampleProductList;
		

		#endregion

		#region Service methods

		private Purchase _get()
		{
			purchase.Count = tbCount.Value;
			purchase.Price = tbPrice.Value;
			purchase.Date = tbDate.Value;
			purchase.Seller = txtSeller.Text;
			purchase.Name = txtPurchaseName.Text;

			return purchase;
		}

		private void _set(Purchase src)
		{
			purchase = src;

			tbCount.Text	= purchase.Count.ToString();
			tbDate.Value	= purchase.Date;
			tbPrice.Text	= purchase.Price.ToString();
			txtSeller.Text	= purchase.Seller;
			txtPurchaseName.Text = purchase.Name;
		}

		#endregion

		public void SetPurchase(Purchase purchase)
		{
			_set(purchase);
		}

		public Purchase GetPurchase()
		{
			ShowDialog();
			if (DialogResult == DialogResult.Cancel) return null;
			return	_get();
		}

		private void EditPurchaseForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (DialogResult.Cancel == this.DialogResult) return;

			//if(purchase.ProductType == null)
			if(string.IsNullOrWhiteSpace(txtPurchaseName.Text))
			{
				e.Cancel = true;
				Messages.ShowError("Не назначено имя продукта", "");
			}
		}

		private void tbPrice_Enter(object sender, EventArgs e)
		{
			var h = sender as NumericUpDown;
			h.Select(0, h.Text.Length);
		}

		private void tbCount_Enter(object sender, EventArgs e)
		{
			var h = sender as NumericUpDown;
			h.Select(0, h.Text.Length);
		}

		private void txtSeller_Leave(object sender, EventArgs e)
		{
			var h = sender as TextBox;
			h.Select(0, h.Text.Length);
		}

		private void tbPrice_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				tbCount.Focus();
			}
		}

		private void tbCount_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				DialogResult = DialogResult.OK;
			}
		}

		private void txtSeller_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				DialogResult = DialogResult.OK;
		}
	}
}
