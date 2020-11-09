using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCustomList
{
	public interface ICreateNoteForm
	{
		string Title { get; set; }
		string Message { get; set; }
		FormResult Display();
	}

	public partial class CreateNoteForm : Form, ICreateNoteForm
	{
		public CreateNoteForm()
		{
			InitializeComponent();
		}

		public string Title { get => txtTitle.Text; set { txtTitle.Text = value; } }
		public string Message { get => txtText.Text; set { txtText.Text = value; } }

		public FormResult Display()
		{
			var res = this.ShowDialog() == DialogResult.OK ? new FormResult(FormResultCode.Ok) : new FormResult(FormResultCode.Cancel);

			if (string.IsNullOrWhiteSpace(txtTitle.Text))
				if (txtText.Text.Length < 10) txtTitle.Text = txtText.Text;
				else
					txtTitle.Text = txtText.Text.Substring(0, 10);

			return res;
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}
	}
}
