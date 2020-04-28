using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyAccouting.BL.Entities
{
	public class Product
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int CashDocumentId { get; set; }
		public int ShopId { get; set; }
		public int CategoryId { get; set; }
		public int TagId { get; set; }
		public Shop Shop { get; set; }
		public Category Category { get; set; }
		public Tag Tag { get; set; }
		public decimal Price { get; set; }
		public decimal Count { get; set; }
		public decimal Sum { get { return Price * Count; } }
		public DateTime Date { get; set; }
	}
}
