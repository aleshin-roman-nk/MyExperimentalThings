using Costs.BL.Domain.Entities;
using Costs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Costs.BL.DB
{
	public static class PayDocumentDBA
	{
		public static IEnumerable<PaymentDoc> GetPaymentDocs(int year, int month)
		{
			throw new NotImplementedException();
		}
		public static IEnumerable<PaymentDoc> GetPaymentDocs(int year, int month, int day)
		{
			throw new NotImplementedException();
		}

		public static void Save(PaymentDoc doc)
		{
			using (AppData db = new AppData())
			{
				foreach (var item in doc.Purchases)
				{
					db.Entry(item).State = item.Id == 0 ? System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;
					db.Entry(item.Directory).State = System.Data.Entity.EntityState.Unchanged;
				}

				db.Entry(doc).State = doc.Id == 0 ? System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;

				db.SaveChanges();
			}
		}
	}
}
