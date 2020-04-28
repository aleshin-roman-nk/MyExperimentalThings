using MoneyAccouting.BL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyAccouting.BL.Models
{
	public class CashDocumentModel
	{
		public IEnumerable<CashDocument> GetDocuments(int year, int month)
		{
			throw new NotImplementedException();
		}

		public void SaveDocument(CashDocument doc)
		{

		}

		public Product CreateProduct(CashDocument doc, Category cat, ProductType ptype, Tag tag)
		{
			return new Product
			{
				CashDocumentId = doc.Id,
				Category = cat,
				Shop = doc.Shop,
				Date = doc.Date,
				Name = ptype.Name,
				Count = 1,
				Price = 0,
				Tag = tag
			};
		}

		public CashDocument CreateDocument(DateTime date, Shop shop, string name)
		{
			return new CashDocument
			{
				Date = date,
				Shop = shop,
				Name = name
			};
		}
	}
}
