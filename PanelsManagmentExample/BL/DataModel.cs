using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrRomic.BL
{
	public class Year
	{
		public int Id { get; set; }
		public string Name { get; set; }
	}
	public class Month
	{
		public int Id { get; set; }
		public int YearId { get; set; }
		public string MName { get; set; }
	}

	public class DataModel
	{
		List<Year> years = new List<Year>();
		List<Month> months = new List<Month>();

		public DataModel()
		{
			years.Add(new Year { Id = 1, Name = "2015" });
			years.Add(new Year { Id = 2, Name = "2016" });
			years.Add(new Year { Id = 3, Name = "2017" });

			months.Add(new Month { Id = 1, MName = "Январь", YearId = 1});
			months.Add(new Month { Id = 2, MName = "Февраль", YearId = 1});
			months.Add(new Month { Id = 3, MName = "Март", YearId = 1});
			months.Add(new Month { Id = 4, MName = "Апрель", YearId = 2});
			months.Add(new Month { Id = 5, MName = "Май", YearId = 2});
			months.Add(new Month { Id = 6, MName = "Июнь", YearId = 2});
			months.Add(new Month { Id = 7, MName = "Декабрь", YearId = 3});
			months.Add(new Month { Id = 8, MName = "Октобер", YearId = 3});
			months.Add(new Month { Id = 9, MName = "Новомб", YearId = 1});
			months.Add(new Month { Id = 10, MName = "Куралесь", YearId = 3});
		}

		public void AddYear(Year y)
		{
			years.Add(y);
		}

		public IEnumerable<Year> GetYears()
		{
			return years;
		}

		public IEnumerable<Month> GetMonths(Year y)
		{
			return months.Where(x => x.YearId == y.Id).ToList();
		}
	}
}
