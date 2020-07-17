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
	public partial class DocumentsForm : Form, IDocumentsView
    {
        BindingSource bsDocuments;
        BindingSource bsDocItems;

		public DocumentsForm()
		{
			InitializeComponent();

            bsDocuments = new BindingSource();
            bsDocItems = new BindingSource();

            dataGridView1.AutoGenerateColumns = false;
        }

		public DateTime Date { get => dateTimeControl.Value; set => dateTimeControl.Value = value; }

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

            bsDocuments.ResetBindings(false);
            bsDocItems.ResetBindings(false);
        }

		private void lbPayDocuments_KeyDown(object sender, KeyEventArgs e)
		{
            if (e.KeyCode != Keys.Enter) return;

            var current = lbPayDocuments.SelectedItem as PaymentDoc;

            if (current == null) return;

            EditDocumentCmd?.Invoke(this, current);
        }

		private void dateTimeControl_ValueChanged(object sender, EventArgs e)
		{
            OnPeriodChanged();
        }

		private void cbOfMonth_CheckedChanged(object sender, EventArgs e)
		{
            OnPeriodChanged();
        }

        private void OnPeriodChanged()
		{
            PeriodChanged?.Invoke(null, new PeriodChangedEventArg(dateTimeControl.Value, cbOfMonth.Checked));
        }
	}
}
