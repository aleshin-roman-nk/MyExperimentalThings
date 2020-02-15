using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkDataModel.Entities
{
	// Повторяет идею таблички работы в ексель ддополнительные работы.
	public class Work
	{
		public int Id { get; set; }
		public DateTime Date { get; set; }
		public List<CalcItem> Items { get; set; }

		public decimal Spending
		{
			get
			{
				decimal res = 0;
				foreach (var item in Items)
				{
					res += item.Sum;
				}
				return res;
			}
		}

		public decimal WantedPercent { get; set; }

		public void SetByRealVolume()
		{
			decimal sum = 9600;
			decimal price = 82;
			decimal volume = Math.Round((sum / price) / 10) * 10;
		}

		public WorkType WorkType { get; set; }

		public 
	}
}
