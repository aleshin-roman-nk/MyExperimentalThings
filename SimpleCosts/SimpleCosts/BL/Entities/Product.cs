using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCosts.BL.Entities
{
	public class Product
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int CategoryId { get; set; }
		public int CashDocumentId { get; set; }
		public decimal Price { get; set; }
		public decimal Amoutn { get; set; }
		public decimal Sum { get { return Price * Amoutn; } }
	}
}
