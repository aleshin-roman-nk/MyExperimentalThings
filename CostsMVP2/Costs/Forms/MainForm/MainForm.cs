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
		public event Action<Directory> CreateDirectory;
		public event Action<Directory> RenameDirectory;
		public event Action<Directory> DeleteDirectory;
		public event Action<MainViewValuesChangedEventArg> RequestValuesChanged;
		public event Action<Category> GetProductTypes;
		public event Action GetCategories;
		public event Action<string> BtnCreateCategory;
		public event Action<string, Category> BtnCreateProductType;
		public event Action<Category> BtnDeleteCategory;
		public event Action<ProductType> BtnDeleteProductType;

		// Конфигурирование блоками-элементами сложной вьюшки
		TreeViewDirectories treeViewDirectories;
		GridPurchases gridPurchases;
		DragDropGridToTree dragDropGridToTree;
		KeyboardGridPurchases keyboardGridPurchases;
		KeyboardTreeDirectories keyboardTreeDirectories;
		RequestsController requestsController;

		ProductTypeDrag<ProductType> productTypeDrag;

		CurrentCategoryObserver viewCurrentObserver;

		public Directory CurrentDirectory => treeViewDirectories.Current;
		public bool OneDay => ucDateView1.OneDay;
		public Category CurrentCategory => viewCurrentObserver.CurrentCategory;
		public DateTime CurrentDate { get => ucDateView1.CurrentDate; }

		public MainForm()
		{
			InitializeComponent();
			
			// 1. Конфигурируем view
			gridPurchases = new GridPurchases(dgvPurchases);
			treeViewDirectories = new TreeViewDirectories(tvDirectories);
			dragDropGridToTree = new DragDropGridToTree(dgvPurchases, tvDirectories);
			keyboardGridPurchases = new KeyboardGridPurchases(dgvPurchases);
			keyboardTreeDirectories = new KeyboardTreeDirectories(tvDirectories);
			requestsController = new RequestsController(treeViewDirectories, ucDateView1);

			productTypeDrag = new ProductTypeDrag<ProductType>(lvProductTypes, dgvPurchases, createPurchase);
			viewCurrentObserver = new CurrentCategoryObserver();

			requestsController.ValuesChanged += RequestsController_ValuesChanged;

			dragDropGridToTree.MovePurchase += TreeViewDirectories_MovePurchase;
			keyboardGridPurchases.CreatePurchase += KeyboardGridPurchases_CreatePurchase;
			keyboardGridPurchases.DeletePurchase += KeyboardGridPurchases_DeletePurchase;
			keyboardGridPurchases.EditPurchase += KeyboardGridPurchases_EditPurchase;

			dragDropGridToTree.MoveDirectory += DragDropGridToTree_MoveDirectory;
			keyboardTreeDirectories.CreateDirectory += KeyboardTreeDirectories_CreateDirectory;
			keyboardTreeDirectories.DeleteDirectory += KeyboardTreeDirectories_DeleteDirectory;
			keyboardTreeDirectories.RenameDirectory += KeyboardTreeDirectories_RenameDirectory;
		}

		private void createPurchase(ProductType pt)
		{
			DateTime dt = ucDateView1.CurrentDate;

			CreatePurchase?.Invoke(pt, dt);
		}

		private void RequestsController_ValuesChanged(MainViewValuesChangedEventArg obj)
		{
			RequestValuesChanged?.Invoke(obj);
		}

		private void KeyboardTreeDirectories_RenameDirectory(Directory obj)
		{
			RenameDirectory?.Invoke(obj);
		}

		private void KeyboardTreeDirectories_DeleteDirectory(Directory obj)
		{
			DeleteDirectory?.Invoke(obj);
		}

		private void KeyboardTreeDirectories_CreateDirectory(Directory obj)
		{
			CreateDirectory?.Invoke(obj);
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

		public void SetPurchases(List<Purchase> ppList)
		{
			gridPurchases.Reload(ppList);
		}

		public void SetDirectories(List<Directory> dirList)
		{
			treeViewDirectories.Reload(dirList);
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

			CreateDirectory?.Invoke(keyboardTreeDirectories.current);
			//MessageBox.Show(CurrentDirectory.Name + " пока не реализовано");
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

			viewCurrentObserver.CurrentCategory = cat;// Кстати, храня во view текущий объект, можно делать что то вроде cat.Clone() если боюсь, что кто то в др месте уничтожит этот экземпляр по ссылке.
			viewCurrentObserver.IsCategoryLevel = false;

			GetProductTypes?.Invoke(cat);
		}
		void exitCategory()
		{
			viewCurrentObserver.IsCategoryLevel = true;

			if (viewCurrentObserver.CurrentCategory == null) return;

			GetCategories?.Invoke();

			var item = lvProductTypes.Items.Cast<ListViewItem>().FirstOrDefault(x => (x.Tag as Category).Id == viewCurrentObserver.CurrentCategory.Id);

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

			if (viewCurrentObserver.IsCategoryLevel)
			{
				BtnCreateCategory?.Invoke(str);
			}
			else
			{
				BtnCreateProductType?.Invoke(str, viewCurrentObserver.CurrentCategory);
			}
		}

		private void btnDeleteProductType()
		{
			if (viewCurrentObserver.IsCategoryLevel)
			{
				if (UserAnsverYes($"Категория {viewCurrentObserver.CurrentCategory.Name} будет удалена со всеми вложенными элементами. Подтвердите."))
					BtnDeleteCategory?.Invoke(viewCurrentObserver.CurrentCategory);
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
	}
}
