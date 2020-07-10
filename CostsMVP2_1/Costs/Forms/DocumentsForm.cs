using Costs.BL.Domain.Entities;
using Costs.Views;
using Costs.Views.EventArgs;
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
 * Показ элементов только одного чека.
 * 
 * Все вводы от юзера, логика UI ввода может размещаться в view отделе. Именно на внесение данных, изменений состояния данных
 *		отправляется в модель.
 *		Это означает, главный view не должен обращаться к презентеру чтобы ввести строку.
 *		Попробовать реализовать эту идею.
 * 
 * 
 */

namespace Costs.Forms.PayDocumentsForm
{
	public partial class DocumentsForm : Form, IDocumentsForm
    {
        BindingSource bsDocuments;
        BindingSource bsDocItems;

		public DocumentsForm()
		{
			InitializeComponent();

            bsDocuments = new BindingSource();
            bsDocItems = new BindingSource();

        }

        public event EventHandler<PeriodChangedEventArg> PeriodChanged;
        public event EventHandler<PaymentDoc> EditDocumentCmd;

        public void Go()
        {
            this.ShowDialog();
        }

        public void SetDocuments(IEnumerable<PaymentDoc> docs)
        {
            bsDocuments.DataSource = docs;
            bsDocItems.DataSource = bsDocuments;
            bsDocItems.DataMember = "Purchases";

            lbPayDocuments.DataSource = bsDocuments;
            lbPayDocuments.DisplayMember = "Title";

            dataGridView1.DataSource = bsDocItems;
        }

		private void lbPayDocuments_KeyDown(object sender, KeyEventArgs e)
		{
            var current = lbPayDocuments.SelectedItem as PaymentDoc;

            if (current == null) return;

            EditDocumentCmd?.Invoke(this, current);
        }
	}
}
