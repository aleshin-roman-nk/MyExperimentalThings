using Costs.BL.Entities;
using Costs.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Costs.Forms
{
	public partial class ShopForm : Form, IShopView
	{
		BindingSource bsItems;

		Shop CurrentShop 
		{ 
			get
			{
				return bsItems.Current as Shop;
			} 
		}

		public ShopForm()
		{
			InitializeComponent();

			bsItems = new BindingSource();
		}

		public event EventHandler<string> AddShop;
		public event EventHandler<Shop> DeleteShop;

		public ViewResult<string> GetResult()
		{
			var ok = ShowDialog() == DialogResult.OK;

			var i = CurrentShop;
			if (i == null) return new ViewResult<string>(null, ResponseCode.Cancel);

			return new ViewResult<string>(i.Name, ok ? ResponseCode.Ok : ResponseCode.Cancel);
		}

		public void SetShops(IEnumerable<Shop> shops)
		{
			bsItems.DataSource = shops;
			listBox1.DataSource = bsItems;
			listBox1.DisplayMember = "Name";
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textBox1.Text)) return;

			AddShop?.Invoke(null, textBox1.Text);
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			DeleteShop?.Invoke(null, CurrentShop);
		}
	}
}
