using MyWeeklyEnglish.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWeeklyEnglish
{
	public partial class Form1 : Form
	{
		bool _state_save = true;
		DataEntryPoint dataEntryPoint = new DataEntryPoint();

		bool _saved
		{
			get
			{
				return _state_save;
			}
			set
			{
				_state_save = value;
				Color c = _state_save ? Color.Green : Color.Red;
				label3.BackColor = c;
			}
		}

		public Form1()
		{
			InitializeComponent();
		}

		private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
		{
			txtThisWeek.Text = dataEntryPoint.make_week_name(e.Start);
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}
	}
}
