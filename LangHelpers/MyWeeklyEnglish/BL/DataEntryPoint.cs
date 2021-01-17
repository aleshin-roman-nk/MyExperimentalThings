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


		/// <summary>
		/// Загрузка недельной сущности по дате.
		/// Происходит вычисление идентификатора (имя) недели, загрузка и сборка сущности.
		/// По существу это просто цель недели.
		/// В дне можно даже задавать задачу, что из помещенного в неделю делать в этот день.
		/// </summary>
		/// <param name="day"></param>
		/// <returns></returns>
		public Week GetWeek(DateTime day)
		{
			return new Week();
		}

		/// <summary>
		/// В дне можно указывать время работы.
		/// </summary>
		/// <param name="day"></param>
		/// <returns></returns>
		public Day GetDay(DateTime day)
		{
			return new Day();
		}

		public void SaveDay(Day d)
		{

		}
		public void SaveWeek(Week w)
		{

		}
	}
}
