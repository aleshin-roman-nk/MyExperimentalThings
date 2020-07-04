using System;

namespace Costs.Entities
{
	public class Purchase
	{
		public int Id { get; set; }
		public int DirectoryID { get; set; }
		public int? PaymentDocId { get; set; }
		// >>> 04-07-2020 14:55
		// I do not want a Purchase entity to have a direct reference to a Directory entity.
		//	Возникает путаница с сохранением сущности Purchase
		public Directory Directory { get; set; }
		public string Name { get; set; }
		public string Info { get; set; }
		public decimal Price { get; set; }
		public decimal Count { get; set; }
		public DateTime Date { get; set; }
		public string Seller { get; set; }
		public decimal Amount { get { return Price * Count; } }
		public string DirName
		{
			get
			{
				return Directory == null ? "-" : Directory.Name;
			}
		}
		public Purchase Clone()
		{
			Purchase res = new Purchase();

			res.Count = Count;
			res.Date = Date;
			res.Price = Price;
			res.DirectoryID = DirectoryID;
			res.Id = Id;
			res.Seller = Seller;
			res.PaymentDocId = PaymentDocId;

			return res;
		}
		public void Accept(Purchase src)
		{

			Count = src.Count;
			Date = src.Date;
			Price = src.Price;
			DirectoryID = src.DirectoryID;
			Id = src.Id;
			Seller = src.Seller;
			PaymentDocId = src.PaymentDocId;
		}
	}
}
