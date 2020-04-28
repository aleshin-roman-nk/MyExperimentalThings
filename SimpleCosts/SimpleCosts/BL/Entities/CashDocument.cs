using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCosts.BL.Entities
{
	public class CashDocument
	{
		public int Id { get; set; }
		public DateTime Date { get; set; }
		public List<Product> Products { get; set; }
		public int ShopId { get; set; }
		public decimal Sum { get { return Products.Sum(x => x.Sum); } }
	}
}
