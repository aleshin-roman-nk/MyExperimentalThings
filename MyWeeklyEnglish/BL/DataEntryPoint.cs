using MyWeeklyEnglish.BL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWeeklyEnglish.BL
{
	public class DataEntryPoint
	{


		private string make_week_name(DateTime day)
		{
			var t = day;

			while (t.DayOfWeek != DayOfWeek.Monday)
			{
				t = t.AddDays(-1);
			}

			return $"{t.Day}_{t.Month}_{t.Year}";
		}

		private string make_day_name(DateTime day)
		{
			return $"day_{day.Day}_{day.Month}{day.Year}";
		}


		//отдельно загружаю неделю
		//и работаю с ней
		public Week GetWeek(DateTime day)
		{

		}

		//отдельно работа с днем.
		public Day GetDay(DateTime day)
		{

		}
	}
}
