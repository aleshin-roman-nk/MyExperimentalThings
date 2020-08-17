using DrRomic.bl;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DrRomic.UI
{
	public interface IMyCalendar
	{
		event Action<DateTime> DateChoosed;
		DateTime CurrentDate { get; }
	}

	public partial class MyCalendar : UserControl, IMyCalendar
	{
		public DateTime CurrentDate { get; private set; } = DateTime.Today;
		public event Action<DateTime> DateChoosed;

		private CurrentPeriod _currentmonth = new CurrentPeriod();

		public MyCalendar()
		{
			InitializeComponent();
			gridCalendar.SelectionChanged += GridCalendar_SelectionChanged;

			_currentmonth.set(CurrentDate);
			UpdateUIMonth(_currentmonth);
			foreach (DataGridViewColumn item in gridCalendar.Columns)
				item.SortMode = DataGridViewColumnSortMode.NotSortable;
			highlightDate(CurrentDate);
		}

		private void GridCalendar_SelectionChanged(object sender, EventArgs e)
		{
			if (gridCalendar.SelectedCells.Count == 0) return;
			if (gridCalendar.SelectedCells[0] == null) return;
			if (gridCalendar.SelectedCells[0].Tag == null)
			{
				//btnSetCurrentMonth.Text = CurrentDate.ToString("MMMM.yyyy");
				return;
			}

			CurrentDate = (DateTime)gridCalendar.SelectedCells[0].Tag;

			//btnSetCurrentMonth.Text = CurrentDate.ToString("dd.MMMM.yyyy");

			DateChoosed?.Invoke(CurrentDate);
		}

		private void btnDown_Click(object sender, EventArgs e)
		{
			_currentmonth.prevMonth();
			UpdateUIMonth(_currentmonth);
		}

		private void btnSetCurrentMonth_Click(object sender, EventArgs e)
		{
			CurrentDate = DateTime.Today;
			_currentmonth.set(CurrentDate);
			UpdateUIMonth(_currentmonth);
			highlightDate(CurrentDate);
		}

		void highlightDate(DateTime dt)
		{
			foreach (DataGridViewRow week in gridCalendar.Rows)
			{
				foreach (DataGridViewCell dayw in week.Cells)
				{
					if (dayw.Tag == null) continue;
					if (dt.Equals((DateTime)dayw.Tag))
					{
						dayw.Selected = true;
						break;
					}
				}
			}
		}

		private void btnUp_Click(object sender, EventArgs e)
		{
			_currentmonth.nextMonth();
			UpdateUIMonth(_currentmonth);
		}

		private void UpdateUIMonth(CurrentPeriod dt)
		{
			fillCalendar(dt);
			var firstday = dt.getFirstDay();
			btnSetCurrentMonth.Text = dt.Title;
			DateChoosed?.Invoke(dt.getFirstDay());
		}

		private void fillCalendar(CurrentPeriod dt)
		{
			gridCalendar.Rows.Clear();

			var days = dt.Days;
			var lastday = days.Last();

			int weekOfMonth = 0;
			gridCalendar.Rows.Add();

			foreach (var item in days)
			{
				int dayOfWeek = (int)item.DayOfWeek;
				if (dayOfWeek == 0) dayOfWeek = 6;
				else
					dayOfWeek--;

				if (dayOfWeek == 6)
				{
					gridCalendar.Rows[weekOfMonth].Cells[dayOfWeek].Value = $"{item.Day}";
					gridCalendar.Rows[weekOfMonth].Cells[dayOfWeek].Tag = item;
					if (item != lastday)
					{
						gridCalendar.Rows.Add();
						weekOfMonth++;
					}
				}
				else
				{
					gridCalendar.Rows[weekOfMonth].Cells[dayOfWeek].Value = $"{item.Day}";
					gridCalendar.Rows[weekOfMonth].Cells[dayOfWeek].Tag = item;
				}
			}
		}

		private void gridCalendar_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
		{
			try
			{
				var o = gridCalendar.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag;
				if (o == null) return;
				DateTime dt = (DateTime)o;
				//if ((dt.Day % 2) == 0) e.CellStyle.BackColor = Color.Yellow;
				if(dt.Month != _currentmonth.Month) e.CellStyle.BackColor = Color.LightGray;
			}
			catch (Exception)
			{
			}
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
