using AllVerbs.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllVerbs
{
	public partial class EditVerbForm : Form, IEditWord
	{
		public EditVerbForm()
		{
			InitializeComponent();
		}

		public string Present { get => textBoxPresent.Text; set { textBoxPresent.Text = value; } }
		public string Past { get => textBoxPast.Text; set { textBoxPast.Text = value; } }
		public string Perfect { get => textBoxPerfect.Text; set { textBoxPerfect.Text = value; } }

		public UserAnswer Go()
		{
			return this.ShowDialog() == DialogResult.OK ? UserAnswer.Ok : UserAnswer.Cancel;
		}
	}
}
