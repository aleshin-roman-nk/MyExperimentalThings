using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskBank.Dlg.forms
{
	public interface IRmTaskForm
	{
		string Show(string txt);
	}

	public partial class RmTaskForm : Form, IRmTaskForm
	{
		public RmTaskForm()
		{
			InitializeComponent();
		}

		public string Show(string txt)
		{
			bool ok = this.ShowDialog() == DialogResult.OK;

			if (ok)
				return richTextBox1.Text;
			else
				return String.Empty;
		}
	}
}
