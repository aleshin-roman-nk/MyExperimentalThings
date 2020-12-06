using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWeeklyEnglish.BL.Entities
{
	public class Week
	{
		public int Id { get; set; }
		public string words { get; set; }
		public List<Day> days { get; set; } = new List<Day>();
	}
}
