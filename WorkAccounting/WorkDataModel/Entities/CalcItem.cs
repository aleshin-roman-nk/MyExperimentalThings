using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkDataModel.Entities
{
	public class CalcItem
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public decimal Price { get; set; }
		public decimal Amount { get; set; }
		public decimal Sum { get { return Price * Amount; } }
		public string Comment { get; set; }
	}
}
