using Costs.DlgService;
using Costs.Domain.Entities;
using Costs.Entities;
using Costs.Forms.Main.InternalViews;
using Costs.Forms.Main.InternalViews.DragDrops;
using Costs.Forms.MainForm;
using Costs.Presenters.Views;
using Costs.Presenters.Views.EventArgs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Отдельный суб view - ответственный за выбор и показ дат выборки

namespace Costs.Forms.Main
{
	public partial class MainForm : Form, IMainView
	{
		public event Action<Purchase, Directory> MovePurchase;
		public event Action<Purchase> EditPurchase;
		public event Action<Purchase> DeletePurchase;
		public event Action<ProductType, DateTime> CreatePurchase;

		public event Action<Directory, Directory> MoveDirectory;
		public event Action<Directory> BtnCreateDirectory;
		public event Action<Directory> BtnRenameDirectory;
		public event Action<Directory> BtnDeleteDirectory;
		public event Action<PurchaseFilterValuesChangedEventArg> ValuesChanged;
		public event Action<Category> UpdateProductTypes;
		public event Action UpdateCategories;
		public event Action<string> BtnCreateCategory;
		public event Action<string, Category> BtnCreateProductType;
		public event Action<Category> BtnDeleteCategory;
		public event Action<ProductType> BtnDeleteProductType;

		// Конфигурирование блоками-элементами сложной вьюшки
		DirectoriesTreeViewHandler directoriesTreeViewHandler;
		PurchasesGridHandler purchasesGrid;
		DragDropGridToTree dragDropGridToTree;
		PurchaseListObserver purchaseListObserver;

		CurrentCategoryObserver сurrentCategoryObserver;

		public Directory CurrentDirectory => directoriesTreeViewHandler.Current;
		public bool OneDay => ucDateView1.OneDay;
		public Category CurrentCategory => сurrentCategoryObserver.CurrentCategory;
		public DateTime CurrentDate { get => ucDateView1.CurrentDate; }

		public MainForm()
		{
			InitializeComponent();
			
			// 1. Конфигурируем view
			purchasesGrid = new PurchasesGridHandler(dgvPurchases);
			directoriesTreeViewHandler = new DirectoriesTreeViewHandler(tvDirectories);
			purchaseListObserver = new PurchaseListObserver(directoriesTreeViewHandler, ucDateView1);

			dragDropGridToTree = new DragDropGridToTree(dgvPurchases, tvDirectories);
			_ = new ProductTypeDrag<ProductType>(lvProductTypes, dgvPurchases, createPurchase);
			
			сurrentCategoryObserver = new CurrentCategoryObserver();

			purchaseListObserver.ValuesChanged += PurchaseListObserver_ValuesChanged;
			dragDropGridToTree.MovePurchase += TreeViewDirectories_MovePurchase;
			purchasesGrid.CreatePurchase += KeyboardGridPurchases_CreatePurchase;
			purchasesGrid.DeletePurchase += KeyboardGridPurchases_DeletePurchase;
			purchasesGrid.EditPurchase += KeyboardGridPurchases_EditPurchase;

			dragDropGridToTree.MoveDirectory += DragDropGridToTree_MoveDirectory;
			directoriesTreeViewHandler.CreateDirectory += KeyboardTreeDirectories_CreateDirectory;
			directoriesTreeViewHandler.DeleteDirectory += KeyboardTreeDirectories_DeleteDirectory;
			directoriesTreeViewHandler.RenameDirectory += KeyboardTreeDirectories_RenameDirectory;
		}

		private void createPurchase(ProductType pt)
		{
			DateTime dt = ucDateView1.CurrentDate;

			CreatePurchase?.Invoke(pt, dt);
		}

		private void PurchaseListObserver_ValuesChanged(PurchaseFilterValuesChangedEventArg obj)
		{
			ValuesChanged?.Invoke(obj);
		}

		private void KeyboardTreeDirectories_RenameDirectory(Directory obj)
		{
			BtnRenameDirectory?.Invoke(obj);
		}

		private void KeyboardTreeDirectories_DeleteDirectory(Directory obj)
		{
			BtnDeleteDirectory?.Invoke(obj);
		}

		private void KeyboardTreeDirectories_CreateDirectory(Directory obj)
		{
			BtnCreateDirectory?.Invoke(obj);
		}

		private void KeyboardGridPurchases_EditPurchase(Purchase obj)
		{
			EditPurchase?.Invoke(obj);
		}

		private void KeyboardGridPurchases_DeletePurchase(Purchase obj)
		{
			DeletePurchase?.Invoke(obj);
		}

		private void KeyboardGridPurchases_CreatePurchase()
		{
			DateTime dt = ucDateView1.CurrentDate;
			CreatePurchase?.Invoke(null, dt);
		}

		private void DragDropGridToTree_MoveDirectory(Directory arg1, Directory arg2)
		{
			MoveDirectory(arg1, arg2);
		}

		private void TreeViewDirectories_MovePurchase(Purchase arg1, Directory arg2)
		{
			MovePurchase(arg1, arg2);
		}

		private void btnAddPurchasedProduct_Click(object sender, EventArgs e)
		{
			DateTime dt = ucDateView1.CurrentDate;
			CreatePurchase?.Invoke(null, dt);
		}

		private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
		{
			tvDirectories.PathSeparator = " \\ ";
			tbDirFullPath.Text = tvDirectories.SelectedNode.FullPath;
		}

		public void SetPurchases(IEnumerable<Purchase> ppList)
		{
			purchasesGrid.SetItems(ppList);
		}

		public void SetDirectories(IEnumerable<Directory> dirList)
		{
			directoriesTreeViewHandler.SetItems(dirList);
		}
		public void SetPurchasesAmount(decimal amount)
		{
			tbCurrentAmount.Text = $"{amount:c}";
		}

		public void ShowError(string msg)
		{
			Messages.ShowError(msg, "");
		}

		public bool UserAnsverYes(string msg)
		{
			return Messages.UserAnsweredYes(msg, "");
		}

		private void tsiAddDirectory_Click(object sender, EventArgs e)
		{
			BtnCreateDirectory?.Invoke(directoriesTreeViewHandler.Current);
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

		public void SetCategories(IEnumerable<Category> categs)
		{
			lvProductTypes.Items.Clear();

			foreach (var item in categs)
			{
				var i = lvProductTypes.Items.Add(item.Name);
				i.Tag = item;
			}
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
			if(e.KeyCode == Keys.Delete)
			{
				btnDeleteProductType();

				e.Handled = true;
				return;
			}
		}

		void enterCategory()
		{
			if (lvProductTypes.SelectedItems.Count == 0) return;

			var cat = lvProductTypes.SelectedItems[0].Tag as Category;
			if (cat == null) return;

			сurrentCategoryObserver.CurrentCategory = cat;// Кстати, храня во view текущий объект, можно делать что то вроде cat.Clone() если боюсь, что кто то в др месте уничтожит этот экземпляр по ссылке.
			сurrentCategoryObserver.IsCategoryLevel = false;

			UpdateProductTypes?.Invoke(cat);
		}
		void exitCategory()
		{
			сurrentCategoryObserver.IsCategoryLevel = true;

			if (сurrentCategoryObserver.CurrentCategory == null) return;

			UpdateCategories?.Invoke();

			var item = lvProductTypes.Items.Cast<ListViewItem>().FirstOrDefault(x => (x.Tag as Category).Id == сurrentCategoryObserver.CurrentCategory.Id);

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
			txtCurrentCategory.Text = (tag as Category).Name;
		}

		private void btnCreateProductType_Click(object sender, EventArgs e)
		{
			string str = Messages.InputText();

			if (string.IsNullOrWhiteSpace(str)) return;

			if (сurrentCategoryObserver.IsCategoryLevel)
			{
				BtnCreateCategory?.Invoke(str);
			}
			else
			{
				BtnCreateProductType?.Invoke(str, сurrentCategoryObserver.CurrentCategory);
			}
		}

		private void btnDeleteProductType()
		{
			if (сurrentCategoryObserver.IsCategoryLevel)
			{
				if (UserAnsverYes($"Категория {сurrentCategoryObserver.CurrentCategory.Name} будет удалена со всеми вложенными элементами. Подтвердите."))
					BtnDeleteCategory?.Invoke(сurrentCategoryObserver.CurrentCategory);
			}
			else
			{
				var pt = lvProductTypes.SelectedItems.Count == 0 ? null : lvProductTypes.SelectedItems[0].Tag as ProductType;

				if (pt == null) return;

				if (UserAnsverYes($"Продукт {pt.Name} будет удален. Подтвердите."))
				{
					BtnDeleteProductType?.Invoke(pt);
				}
			}
		}

		private ProductType getCurrentProductType()
		{
			return lvProductTypes.SelectedItems.Count == 0 ? null : lvProductTypes.SelectedItems[0].Tag as ProductType;
		}

		private void lvProductTypes_DoubleClick(object sender, EventArgs e)
		{
			enterCategory();
		}

		private void btnExitCategory_Click(object sender, EventArgs e)
		{
			exitCategory();
		}

		private void btnAddShopItem_Click(object sender, EventArgs e)
		{
			DateTime dt = ucDateView1.CurrentDate;
			CreatePurchase?.Invoke(null, dt);
		}

		private void btnDocumentsView_Click(object sender, EventArgs e)
		{
			ViewDocumentForm f = new ViewDocumentForm();
			f.ShowDialog();
		}
	}
}
