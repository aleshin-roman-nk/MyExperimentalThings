using Costs.Domain.Entities;
using Costs.Entities;
using Costs.Presenters.Views;
using Costs.Views.EventArgs;
using Costs.Views.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

// Отдельный суб view - ответственный за выбор и показ дат выборки


/*
 * 
 * 
 * 
 * >>>
 * 26-06-2020 18:00
 * Компонент работы с покупками так же содержит работу с директориями. Это общий UserControlPurchases
 *	Но выборка по датам устанавливается извне. Т.е. работа с датами это отдельный компонент.
 *		Изменение даты передается в компонент UserControlPurchases извне.
 *		
 *		Точнее дата даже не передается в этот модуль. Ему всеравно какая дата.
 * 
 * А может разделить IView и сделать вложенные IView
 *	UserControl реализует конкретный IView а главный IView возвращает нужный экземпляр.
 *		В разделе Presenter так же конкретные части берут свой IView и работают с ним.
 * 
 * >>>
 * 26-06-2020 20:55
 * Мы можем просто уведомлять что список изменился и нужно пересчитать сумму элементов в выбранной директории
 * 
 */

namespace Costs.Forms.Main
{
	public partial class MainForm : Form, IMainView
	{
		public event Action CreateDocumentCmd;
        public event Action ShowDocumentsViewerCmd;

        // I would prefer to pass data into the presenter through an event rather than this way (a presenter reads a public property)

        public IPurchasesViewPart PurchasesView => purchasesUC1;

		public IDirectoriesViewPart DirectoriesView => directoriesUC1;

		public IDateSelectorViewPart DateSelector => ucDateView1;

		public MainForm()
		{
			InitializeComponent();
		}

		private void btnAddShopItem_Click(object sender, EventArgs e)
		{
			CreateDocumentCmd?.Invoke();
		}

        private void btnShowDocumentsViewer_Click(object sender, EventArgs e)
        {
            ShowDocumentsViewerCmd?.Invoke();
        }
    }
}
