using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Costs.Views.EventArgs;
using Costs.Views.Parts;

namespace Costs.Forms.Main.InternalViews
{
	public partial class DateViewUC : UserControl, IDateSelectorViewPart
	{
		public DateTime CurrentDate { get => dtDate.Value; }

		public bool OneMonth
		{
			get => cbOneMonth.Checked;
		}

		public event Action<PeriodChangedEventArg> ValuesChanged;

		public DateViewUC()
		{
			InitializeComponent();
			updateDate();
		}

		private void updateDate()
		{
			ValuesChanged?.Invoke(new PeriodChangedEventArg(dtDate.Value, OneMonth));
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
}
