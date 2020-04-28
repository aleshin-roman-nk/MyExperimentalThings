using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragDropMechanism
{
	public interface ViewMain
	{
		void SetItemsType(IEnumerable<ProductType> items);
		void SetItemsProducts(IEnumerable<Product> items);
	}
	public partial class Form1 : Form, ViewMain
	{
		Model model = new Model();
		//MoveFromTo<ProductType> moveFromTo;

		public Form1()
		{
			InitializeComponent();

			//SetItemsType(model.ProductTypes);
			SetItemsProducts(model.Products);
			SetCategories(model.Categories);

			new MoveFromTo<ProductType>(listViewTypes, listViewProducts, createProduct);
		}
		public void SetItemsProducts(IEnumerable<Product> items)
		{
			listViewProducts.Items.Clear();

			foreach (var item in items)
			{
				var i = listViewProducts.Items.Add(item.Name);
				i.Tag = item;
			}
		}
		public void SetItemsType(IEnumerable<ProductType> items)
		{
			listViewTypes.Items.Clear();

			foreach (var item in items)
			{
				var i = listViewTypes.Items.Add(item.Name);
				i.Tag = item;
			}
		}
		public void SetCategories(IEnumerable<Category> cats)
		{
			listViewTypes.Items.Clear();

			foreach (var item in cats)
			{
				var i = listViewTypes.Items.Add(item.Name);
				i.Tag = item;
			}
		}
		void createProduct(ProductType p)
		{
			model.AddProduct(p);
			SetItemsProducts(model.Products);
		}
		private void listViewTypes_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				if (listViewTypes.SelectedItems.Count == 0) return;

				var cat = listViewTypes.SelectedItems[0].Tag as Category;
				if (cat == null) return;

				SetItemsType(cat.Items);
				model.CurrentCategory = cat;// Кстати, храня во view текущий объект, можно делать что то вроде cat.Clone() если боюсь, что кто то в др месте уничтожит этот экземпляр по ссылке.

				e.Handled = true;
				return;
			}

			if(e.KeyCode == Keys.Back)
			{
				SetCategories(model.Categories);

				var coll = listViewTypes.Items.Cast<ListViewItem>().FirstOrDefault(x=>(x.Tag as Category).Id == model.CurrentCategory.Id);

				if (coll != null)
				{
					coll.Selected = true;
					coll.Focused = true;
				}

				listViewTypes.Select();

				e.Handled = true;
				return;
			}
		}
	}
}
