using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyAccouting.BL.Entities
{
	public class CashDocument
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public DateTime Date { get; set; }
		public List<Product> Products { get; set; }
		public int ShopId { get; set; }
		public Shop Shop { get; set; }
		public decimal TotalSum { get { return Products.Sum(x => x.Sum); } }
	}
}
