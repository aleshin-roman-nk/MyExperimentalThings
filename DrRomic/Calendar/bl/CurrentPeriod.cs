using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace DrRomic.bl
{
	internal class CurrentPeriod
	{
		private int _year { get; set; }
		private int _month { get; set; }

		public int Month { get => _month; }
		public int Year { get => _year; }
		public IEnumerable<DateTime> Days { get => dayCollection; }
		public string Title { get; private set; }

		public void nextMonth()
		{
			if (_month == 12)
			{
				_month = 1;
				_year++;
			}
			else _month++;

			_reloadcollection();
			//dayCollection = GetDates(_year, _month);
		}
		public void prevMonth()
		{
			if (_month == 1)
			{
				_month = 12;
				_year--;
			}
			else _month--;

			_reloadcollection();
			//dayCollection = GetDates(_year, _month);
		}
		public void set(DateTime dt)
		{
			_year = dt.Year;
			_month = dt.Month;

			_reloadcollection();
			//dayCollection = GetDates(_year, _month);
		}
		void _reloadcollection()
		{
			dayCollection.Clear();
			dayCollection.AddRange(GetDates(_year, _month));
			Title = new DateTime(Year, Month, 1).ToString("yyyy.MMMM");
		}
		public DateTime getFirstDay()
		{
			return Days.First();
		}

		private List<DateTime> dayCollection = new List<DateTime>();
		private List<DateTime> GetDates(int year, int month)
		{
			//DateTime firstDayOfTheMonth = new DateTime(year, month, 1);

			var daysBefore = getDaysBeforeMonth(year, month);
			var thismonthdays = Enumerable.Range(1, DateTime.DaysInMonth(year, month))
							 .Select(day => new DateTime(year, month, day))
							 .ToList();
			var daysAfter = getDaysAfterMonth(year, month);

			List<DateTime> res = new List<DateTime>();

			res.AddRange(daysBefore);
			res.AddRange(thismonthdays);
			res.AddRange(daysAfter);

			return res;
		}

		private DateTime getMonday(DateTime today)
		{
			DateTime res = today;

			while (res.DayOfWeek != DayOfWeek.Monday)
			{
				res = res.AddDays(-1);
			}

			return res;
		}

		private List<DateTime> getDaysBeforeMonth(int year, int month)
		{
			var firstday = new DateTime(year, month, 1);

			DateTime currentday = getMonday(firstday);

			List<DateTime> res = new List<DateTime>();

			while (currentday != firstday)
			{
				res.Add(currentday);
				currentday = currentday.AddDays(1);
			}

			return res;
		}

		private List<DateTime> getDaysAfterMonth(int year, int month)
		{
			DateTime currentday = new DateTime(year, month, DateTime.DaysInMonth(year, month));

			List<DateTime> res = new List<DateTime>();

			while (currentday.DayOfWeek != DayOfWeek.Sunday)
			{
				currentday = currentday.AddDays(1);
				res.Add(currentday);
			}

			return res;
		}
	}
}
