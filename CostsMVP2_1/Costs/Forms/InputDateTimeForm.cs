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

namespace Costs.Forms
{
	public partial class InputDateTimeForm : Form, IInputDateTimeView
	{
		public InputDateTimeForm()
		{
			InitializeComponent();
		}

		public DateTime UserDateTime => dateTimePicker1.Value;

		public void Go()
		{
			this.ShowDialog();
		}

		private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
		{
			if(Keys.Enter == e.KeyCode)
			{
				DialogResult = DialogResult.OK;
			}
		}
	}
}
