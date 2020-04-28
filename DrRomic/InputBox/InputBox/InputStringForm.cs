using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrRomic.Dialogs
{
	internal interface IMainView
	{
		string GetText(string title, string init_text = null);
	}
	internal partial class InputStringForm : Form, IMainView
	{
		public InputStringForm()
		{
			InitializeComponent();
		}

		public string GetText(string title, string init_text = null)
		{
			txtTitle.Text = "";
			txtTitle.Text = title;
			txtResult.Text = init_text == null ? "" : init_text;
			var res = this.ShowDialog();
			if (res == DialogResult.OK) return txtResult.Text; else return null;
		}
	}
}
