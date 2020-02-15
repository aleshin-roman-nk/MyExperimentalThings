using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIImagine
{
	public interface IMonthChoose
	{
		event Action<DateTime> MonthChoosed;
		DateTime Date { get; }
	}

	public partial class MonthChoose : UserControl, IMonthChoose
	{
		DateTime _date = DateTime.Today;

		public MonthChoose()
		{
			InitializeComponent();
			btnMonth.Text = _date.ToString("yyyy.MMMM");
		}

		public DateTime Date => _date;

		public event Action<DateTime> MonthChoosed;

		private void btnDown_Click(object sender, EventArgs e)
		{
			_date = _date.AddMonths(-1);
			MonthChoosed?.Invoke(_date);
			btnMonth.Text = _date.ToString("yyyy.MMMM");
		}

		private void btnUp_Click(object sender, EventArgs e)
		{
			_date = _date.AddMonths(1);
			MonthChoosed?.Invoke(_date);
			btnMonth.Text = _date.ToString("yyyy.MMMM");
		}

		private void btnMonth_Click(object sender, EventArgs e)
		{
			_date = DateTime.Today;
			MonthChoosed?.Invoke(_date);
			btnMonth.Text = _date.ToString("yyyy.MMMM");
		}
	}
}
