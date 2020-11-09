using Costs.BL.Domain.Entities;
using Costs.Domain.Entities;
using Costs.Entities;
using Costs.Forms.Main.InternalViews;
using Costs.Forms.Common;
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
using Costs.Views.Parts;

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
	public partial class EditDocumentForm : Form, IEditDocumentView
	{
		public EditDocumentForm()
		{
			InitializeComponent();

			dateTimeControl.Value = DateTime.Now;

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

		public IPurchasesViewPart PurchasesView => purchasesUC1;

		public IDirectoriesViewPart DirectoriesView => directoriesUC1;

		public ICategoriesViewPart CategoriesView => categoriesUC1;

		public DateTime CurrentDateTime { get => dateTimeControl.Value; set => dateTimeControl.Value = value; }

		public string Shop { get => txtShopName.Text; set => txtShopName.Text = value; }

		public event EventHandler ShopNameRequested;

		public void SetCategories(IEnumerable<Category> categs)
		{
			throw new NotImplementedException();
		}

		public void SetDirectories(IEnumerable<Directory> dirList)
		{
			
		}

		public void SetProductTypes(IEnumerable<ProductType> items)
		{
			throw new NotImplementedException();
		}

		private void btnSaveAndClose_Click(object sender, EventArgs e)
		{

		}

		private void btnCancel_Click(object sender, EventArgs e)
		{

		}

		private void chbShowWholeDoc_CheckedChanged(object sender, EventArgs e)
		{
			//if (chbShowWholeDoc.Checked) treeViewDirectories.Enabled = false;
			//else treeViewDirectories.Enabled = true;
		}

		ViewResult IEditDocumentView.GetResult()
		{
			var ok = this.ShowDialog() == DialogResult.OK;
			var res = new ViewResult(ok ? ResponseCode.Ok : ResponseCode.Cancel);
			return res;
		}

		private void btnGetShopName_Click(object sender, EventArgs e)
		{
			ShopNameRequested?.Invoke(null, EventArgs.Empty);
		}

		private void categoriesUC1_KeyDown(object sender, KeyEventArgs e)
		{

		}
	}
}
