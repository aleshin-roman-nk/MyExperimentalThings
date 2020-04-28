using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costs.Forms.Main.InternalViews
{
	internal class MonthesMap
	{
		Dictionary<int, string> monthes = new Dictionary<int, string>();

		public MonthesMap()
		{
			monthes.Add(1, "Январь");
			monthes.Add(2, "Февраль");
			monthes.Add(3, "Март");
			monthes.Add(4, "Апрель");
			monthes.Add(5, "Май");
			monthes.Add(6, "Июнь");
			monthes.Add(7, "Июль");
			monthes.Add(8, "Август");
			monthes.Add(9, "Сентябрь");
			monthes.Add(10, "Октябрь");
			monthes.Add(11, "Ноябрь");
			monthes.Add(12, "Декабрь");
		}

		public string this[int m]
		{
			get
			{
				if (monthes.ContainsKey(m))
					return monthes[m];
				return string.Empty;
			}
		}
	}
}
