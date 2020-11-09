using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpMonthCalendarBuildTasks.BL
{
	public class MonthCalendar
	{
		List<DateTime> dates;
		public string MonthName { get; set; }
		public MonthCalendar(int year, int month)
		{
			dates = GetDates(year, month);
			MonthName = new DateTime(year, month, 1).ToString("MMMM");
		}
		private List<DateTime> GetDates(int year, int month)
		{
			return Enumerable.Range(1, DateTime.DaysInMonth(year, month))
							 .Select(day => new DateTime(year, month, day))
							 .ToList();
		}
		public int GetDayAmount(int dayOfWeek)
		{
			if (dayOfWeek == 7) dayOfWeek = 0;
			return dates.Where(x => int.Parse(x.DayOfWeek.ToString("d")) == (int)dayOfWeek).Count();
		}
		public int GetDayAmountOfRange(int[] dayOfWeek)
		{
			var days = dayOfWeek.Select(x => x == 7 ? 0 : x).ToArray();

			return dates.Where(x => 
			days.Contains( int.Parse(x.DayOfWeek.ToString("d")) )).Count();
		}
	}
	public enum MyDaysOfWeek { Sunday = 0, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday}
	public class TaskPosition
	{
		Dictionary<int, bool> days;
		public TaskPosition(string name, decimal budget, params int[] d)
		{
			Name = name;
			Budget = budget;
			days = new Dictionary<int, bool>();
			foreach (var item in d)
			{
				days[item] = true;
			}
		}
		public string Name { get; set; }
		public IEnumerable<int> DaysOfWeeks
		{
			get
			{
				return days.Where(x => x.Value).Select(x => x.Key).ToList();
			}
		}

		public decimal Budget { get; set; }
		public int ShiftAmout { get; set; }
		public decimal ShiftPrice
		{
			get
			{
				decimal price = Budget / ShiftAmout;

				var d = 2;
				price /= d;
				price = price - Math.Truncate(price) == 0 ? price * d : (Math.Truncate(++price) * d);

				return price; // 2222.2222222, нужно получить 2225
			}
		}
	}
}