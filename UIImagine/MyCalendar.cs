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
	public interface IMyCalendar
	{
		event Action<DateTime> DateChoosed;
		DateTime Date { get; }
	}

	public partial class MyCalendar : UserControl, IMyCalendar
	{
		public DateTime Date { get; private set; } = DateTime.Today;
		public event Action<DateTime> DateChoosed;

		public MyCalendar()
		{
			InitializeComponent();
			gridCalendar.SelectionChanged += GridCalendar_SelectionChanged;
		}

		private void GridCalendar_SelectionChanged(object sender, EventArgs e)
		{
			if (gridCalendar.SelectedCells.Count == 0) return;
			if (gridCalendar.SelectedCells[0] == null) return;
			if (gridCalendar.SelectedCells[0].Value == null)
			{
				btnDateDay.Text = "-";
				return;
			}

			int day = (int)gridCalendar.SelectedCells[0].Value;

			Date = new DateTime(Date.Year, Date.Month, day);

			btnDateDay.Text = day.ToString();

			DateChoosed?.Invoke(Date);
		}

		private void btnDown_Click(object sender, EventArgs e)
		{
			Date = Date.AddMonths(-1);
			UpdateUIMonth(Date);
		}

		private void btnSetCurrentMonth_Click(object sender, EventArgs e)
		{
			Date = DateTime.Today;
			UpdateUIMonth(Date);
		}

		private void btnUp_Click(object sender, EventArgs e)
		{
			Date = Date.AddMonths(1);
			UpdateUIMonth(Date);
		}

		private void btnDateDay_Click(object sender, EventArgs e)
		{
			Date = DateTime.Today;
			btnDateDay.Text = Date.Day.ToString();
			UpdateUIMonth(Date);
		}

		private void UpdateUIMonth(DateTime dt)
		{
			fetchCalendar(dt);
			btnSetCurrentMonth.Text = dt.ToString("yyyy.MMMM");
			DateChoosed?.Invoke(dt);
		}

		private void fetchCalendar(DateTime dt)
		{
			gridCalendar.Rows.Clear();

			var month = GetDates(dt.Year, dt.Month);

			int weekOfMonth = gridCalendar.Rows.Add();

			foreach (var item in month)
			{
				int dayOfWeek = int.Parse(item.DayOfWeek.ToString("d"));
				if (dayOfWeek == 0) dayOfWeek = 6;
				else
					dayOfWeek = dayOfWeek - 1;

				string txt = $"{item.Day}";

				if (dayOfWeek == 6)
				{
					gridCalendar.Rows[weekOfMonth].Cells[dayOfWeek].Value = txt;
					weekOfMonth = gridCalendar.Rows.Add();
				}
				else
					gridCalendar.Rows[weekOfMonth].Cells[dayOfWeek].Value = txt;
			}
		}

		private List<DateTime> GetDates(int year, int month)
		{
			return Enumerable.Range(1, DateTime.DaysInMonth(year, month))
							 // Days: 1, 2 ... 31 etc.
							 .Select(day => new DateTime(year, month, day))
							 // Map each day to a date
							 .ToList(); // Load dates into a list
		}
		/*
		 * Хочу вести ежедневный план. Отработать 2 часа по англ, записать в статистику.
		 * И пометка, что делал. Что изучил, для того, чтобы потом планировать повторение.
		 * 
		 * 
		 * связанные панели. а если попробовать пока только отображать в гриде объекты. без логики доп панели.
		 *		отрабюотать сначала этот механизм, без доп сложностей.
		 * 
		 */
	}
}
