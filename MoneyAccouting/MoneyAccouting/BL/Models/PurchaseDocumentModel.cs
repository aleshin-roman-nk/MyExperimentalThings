using MoneyAccouting.BL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyAccouting.BL.Models
{
	public class PurchaseDocumentModel
	{
		public IEnumerable<PurchaseDocument> GetDocuments(int year, int month)
		{
			throw new NotImplementedException();
		}

		public void SaveDocument(PurchaseDocument doc)
		{

		}

		public Product CreateProduct(PurchaseDocument doc, Category cat, ProductType ptype, Tag tag)
		{
			return new Product
			{
				PurchaseDocumentId = doc.Id,
				Category = cat,
				Shop = doc.Shop,
				Date = doc.Date,
				Name = ptype.Name,
				Count = 1,
				Price = 0,
				Tag = tag
			};
		}

		public PurchaseDocument CreateDocument(DateTime date, Shop shop, string name)
		{
			return new PurchaseDocument
			{
				Date = date,
				Shop = shop,
				Name = name
			};
		}
	}
}
