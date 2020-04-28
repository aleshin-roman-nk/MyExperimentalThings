using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Costs.Forms.Main.InternalViews
{
	public partial class UcDateView : UserControl
	{
		public DateTime CurrentDate { get => dtDate.Value; }

		public bool OneDay
		{
			get => !cbOneDay.Checked;
		}

		public event Action<DateChangedEventArg> ValuesChanged;

		public UcDateView()
		{
			InitializeComponent();
			updateDate();
		}

		private void updateDate()
		{
			ValuesChanged?.Invoke(new DateChangedEventArg(dtDate.Value, OneDay));
		}

		private void cbOneDay_CheckedChanged(object sender, EventArgs e)
		{
			updateDate();
		}

		private void dtDate_ValueChanged(object sender, EventArgs e)
		{
			updateDate();
		}
	}

	public class DateChangedEventArg
	{
		public DateChangedEventArg(DateTime date, bool one_month)
		{
			Date = date;
			OneMonth = one_month;
		}

		public DateTime Date;
		public bool OneMonth { get; private set; }
	}
}
