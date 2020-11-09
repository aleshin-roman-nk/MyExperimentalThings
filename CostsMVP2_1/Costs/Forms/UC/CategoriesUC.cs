using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Costs.Entities;
using Costs.Views.Parts;
using Costs.Domain.Entities;

namespace Costs.Forms.UC
{
	public partial class CategoriesUC : UserControl, ICategoriesViewPart
	{
		CurrentCategoryObserver currentCategoryObserver;

		public CategoriesUC()
		{
			InitializeComponent();

			currentCategoryObserver = new CurrentCategoryObserver();
			
		}

		public Category CurrentCategory => currentCategoryObserver.CurrentCategory;

		public event Action<Category> UpdateProductTypes;
		public event Action UpdateCategories;
		public event Action CreateCategoryCmd;
		public event Action<Category> CreateProductTypeCmd;
		public event Action<Category> DeleteCategoryCmd;
		public event Action<ProductType> DeleteProductTypeCmd;
		public event Action<ProductType> AddPointToDoc;

		public void SetCategories(IEnumerable<Category> categs)
		{
			lvProductTypes.Items.Clear();

			foreach (var item in categs)
			{
				var i = lvProductTypes.Items.Add(item.Name);
				i.Tag = item;
			}
		}

		public void SetProductTypes(IEnumerable<ProductType> items)
		{
			lvProductTypes.Items.Clear();

			foreach (var item in items)
			{
				var i = lvProductTypes.Items.Add(item.Name);

				i.Tag = item;
			}
		}

		private void lvProductTypes_ItemDrag(object sender, ItemDragEventArgs e)
		{
			ListView lv = ((ListView)sender);
			var p = (e.Item as ListViewItem).Tag as ProductType;
			if (p == null) return;
			lv.DoDragDrop(p, DragDropEffects.All);
		}

		void enterCategory()
		{
			if (lvProductTypes.SelectedItems.Count == 0) return;

			//var cat = lvProductTypes.SelectedItems[0].Tag as Category;
			//if (cat == null) return;

			//currentCategoryObserver.CurrentCategory = cat;// Кстати, храня во view текущий объект, можно делать что то вроде cat.Clone() если боюсь, что кто то в др месте уничтожит этот экземпляр по ссылке.
			//currentCategoryObserver.IsCategoryLevel = false;

			//UpdateProductTypes?.Invoke(cat);

			var _item = lvProductTypes.SelectedItems[0].Tag;

			if(_item is Category)
			{
				// enter category
				currentCategoryObserver.CurrentCategory = _item as Category;
				currentCategoryObserver.IsCategoryLevel = false;
				UpdateProductTypes?.Invoke(_item as Category);
			}
			else
			{
				// rise an event to add a point into the document
				AddPointToDoc?.Invoke(_item as ProductType);
			}

		}
		void exitCategory()
		{
			currentCategoryObserver.IsCategoryLevel = true;

			if (currentCategoryObserver.CurrentCategory == null) return;

			UpdateCategories?.Invoke();

			var item = lvProductTypes.Items.Cast<ListViewItem>().FirstOrDefault(x => (x.Tag as Category).Id == currentCategoryObserver.CurrentCategory.Id);

			if (item != null)
			{
				item.Selected = true;
				item.Focused = true;
			}

			lvProductTypes.Select();
		}

		private void lvProductTypes_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lvProductTypes.SelectedItems.Count == 0) return;
			var tag = lvProductTypes.SelectedItems[0].Tag;
			if (tag == null) return;
			if (!(tag is Category)) return;

			var cat = tag as Category;

			currentCategoryObserver.CurrentCategory = cat;
			txtCurrentCategory.Text = cat.Name;
		}

		private void lvProductTypes_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				enterCategory();

				e.Handled = true;
				return;
			}

			if (e.KeyCode == Keys.Back)
			{
				exitCategory();

				e.Handled = true;
				return;
			}
			if (e.KeyCode == Keys.Delete)
			{
				btnDeleteProductType();

				e.Handled = true;
				return;
			}
		}

		private void btnDeleteProductType()
		{
			if (currentCategoryObserver.IsCategoryLevel)
			{
				DeleteCategoryCmd?.Invoke(currentCategoryObserver.CurrentCategory);
			}
			else
			{
				var pt = lvProductTypes.SelectedItems.Count == 0 ? null : lvProductTypes.SelectedItems[0].Tag as ProductType;

				if (pt == null) return;
				DeleteProductTypeCmd?.Invoke(pt);
			}
		}

		private void btnCreateProductType_Click(object sender, EventArgs e)
		{
			if (currentCategoryObserver.IsCategoryLevel)
			{
				CreateCategoryCmd?.Invoke();
			}
			else
			{
				CreateProductTypeCmd?.Invoke(currentCategoryObserver.CurrentCategory);
			}
		}

		private void btnExitCategory_Click(object sender, EventArgs e)
		{
			exitCategory();
		}

		private void lvProductTypes_DoubleClick(object sender, EventArgs e)
		{
			enterCategory();
		}
	}

	class CurrentCategoryObserver
	{
		public Category CurrentCategory { get; set; } = null;
		public bool IsCategoryLevel { get; set; } = true;
	}
}
