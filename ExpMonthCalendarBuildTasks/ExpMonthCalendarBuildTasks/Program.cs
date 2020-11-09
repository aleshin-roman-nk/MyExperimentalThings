using ExpMonthCalendarBuildTasks.BL;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpMonthCalendarBuildTasks
{
	class Program
	{
		static void Main(string[] args)
		{

			//MonthCalendar o = new MonthCalendar(2020, 3);

			//List<TaskPosition> taskPosition = new List<TaskPosition>();

			//taskPosition.Add(new TaskPosition("Ночная уборка Группа 1", 20000m, 1, 4));
			//taskPosition.Add(new TaskPosition("Ночная уборка Группа 2", 18000m, 2, 5));
			//taskPosition.Add(new TaskPosition("Ночная уборка Группа 3", 18000m, 3, 7));

			//Console.WriteLine(o.MonthName);

			//foreach (var item in taskPosition)
			//{
			//	var shcnt = o.GetDayAmountOfRange(item.DaysOfWeeks.ToArray());
			//	item.ShiftAmout = shcnt;
			//	Console.WriteLine($"{item.Name} \t:{shcnt} смен; Бюджет {item.Budget}; Стоимость смены {item.ShiftPrice}");
			//}

			TestClass tc = new TestClass();

			tc.MyEvent += (x, y) =>
			{
				Console.WriteLine("");
			};

			Console.ReadLine();
		}
	}
}
