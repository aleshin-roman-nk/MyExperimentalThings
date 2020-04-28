using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Costs.Forms.Main.InternalViews.DateView
{
	public partial class FormMonthesSelect : Form
	{
		public int SelectedMonth { get; private set; } = 1;

		public FormMonthesSelect()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			SelectedMonth = int.Parse((sender as Button).Tag.ToString());
		}
	}
}
