using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkDataModel.Entities
{
	public class WorkType
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public decimal PricePerUnit { get; set; }
		public string UnitName { get; set; }
	}
}
