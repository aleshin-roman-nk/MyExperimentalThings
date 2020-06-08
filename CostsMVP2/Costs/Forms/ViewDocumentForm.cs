using Costs.BL.Domain.Entities;
using Costs.Domain.Entities;
using Costs.Entities;
using Costs.Forms.Main.InternalViews;
using Costs.Forms.Main.InternalViews.DragDrops;
using Costs.Forms.MainForm;
using Costs.Presenters.Views.EventArgs;
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

/*
 * >>>
 * 06-06-2020 15:18
 * Работа с одним документом.
 * + создание, изменение, удаление позиций документа.
 * + модуль принимает только один документ.
 * 
 * 
 */

namespace Costs.Forms
{
	public partial class ViewDocumentForm : Form, IViewDocument
	{
		PaymentDoc paymentDoc = null;

		DirectoriesTreeViewHandler directoriesTreeViewHandler;
		PurchasesGridHandler purchasesGridHandler;
		DragDropGridToTree dragDropGridToTree;

		CurrentCategoryObserver сurrentCategoryObserver;

		public ViewDocumentForm()
		{
			InitializeComponent();

			dateTimeControl.Value = DateTime.Now;

			directoriesTreeViewHandler = new DirectoriesTreeViewHandler(treeViewDirectories);
			purchasesGridHandler = new PurchasesGridHandler(dgvPurchases);
			dragDropGridToTree = new DragDropGridToTree(dgvPurchases, treeViewDirectories);

			/*
			 * >>>
			 * 06 - 06 - 2020 16:27
			 * 
			 * отработать реакцию на изменение директории и даты...
			 * хотя изменение даты не актуально для одного документа.
			 * 
			 * вопрос изменения родительской директории.
			 * это или во view менять и иметь метод двойной операции
			 *	void setdir()
			 *	{
			 *		curpurch.dirid = newdirid; // изменяем текущий загруженный объект
			 *		db.save(curpurch);// сохраняем в бд, без необходимости вновт обращаться для того чтобы вновь загрузить из бд
			 *	}
			 * 
			 * при таком подходе появляется логика изменений сущности во view
			 *	но мы можем писать view-model, которые выносят код логики изменения сущностей за пределы класса формы.
			 *	получается частично бизнесс логика на стороне клиента view.
			 * всетаки остановимся, что во view прячем только все вспомогательные окна подтверждения пользователя.
			 * даже мелкие изменения (перенос связи одной сущности с другой, например) либо в презентере, который интерактирует между
			 *	моделью и view, либо в модели.
			 *	
			 * view возбуждает event и презентер реагирует. это закон MVP
			 * 
			 * 
			 */
		}

		public Directory CurrentDirectory => throw new NotImplementedException();

		public DateTime CurrentDate => throw new NotImplementedException();

		public Category CurrentCategory => throw new NotImplementedException();

		public event Action<ProductType, DateTime> CreatePurchase;
		public event Action<Purchase> EditPurchase;
		public event Action<Purchase> DeletePurchase;
		public event Action<Purchase, Directory> MovePurchase;
		public event Action<Category> ProductTypesRequired;
		public event Action CategoriesRequired;
		public event Action<string> BtnCreateCategory;
		public event Action<string, Category> BtnCreateProductType;
		public event Action<Category> BtnDeleteCategory;
		public event Action<ProductType> BtnDeleteProductType;
		public event Action<DateTime, Directory> ValuesChanged;
		public event Action<Directory, Directory> MoveDirectory;
		public event Action<Directory> BtnCreateDirectory;
		public event Action<Directory> BtnRenameDirectory;
		public event Action<Directory> BtnDeleteDirectory;

		public void SetCategories(IEnumerable<Category> categs)
		{
			throw new NotImplementedException();
		}

		public void SetDirectories(List<Directory> dirList)
		{
			throw new NotImplementedException();
		}

		public void SetDoc(PaymentDoc doc)
		{
			throw new NotImplementedException();
		}

		public void SetProductTypes(IEnumerable<ProductType> items)
		{
			throw new NotImplementedException();
		}

		public void ShowError(string msg)
		{
			throw new NotImplementedException();
		}

		public bool UserAnsverYes(string msg)
		{
			throw new NotImplementedException();
		}

		private void btnSaveAndClose_Click(object sender, EventArgs e)
		{

		}

		private void btnCancel_Click(object sender, EventArgs e)
		{

		}

		public bool ShowForm()
		{
			return this.ShowDialog() == DialogResult.OK;
		}
	}
}
