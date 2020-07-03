using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Costs.Forms.DlgService
{
	public partial class InputTextForm : Form
	{
		public InputTextForm()
		{
			InitializeComponent();
		}

		public void SetInitText(string init_text, string title = null)
		{
			textBox1.Text = title;
			tbText.Text = init_text;
		}

		public string InputedText { get => tbText.Text; }
	}
}
