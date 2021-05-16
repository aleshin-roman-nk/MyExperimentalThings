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
		public static IEnumerable<PaymentDoc> GetPaymentDocs(DateTime from, DateTime to)
		{
			using (AppData db = new AppData())
			{
				return db.PaymentDocs.Include("Purchases").Where(x => x.DateTime >= from && x.DateTime <= to).OrderBy(x=>x.DateTime).ToList();
			}
		}
		public static void Save(PaymentDoc doc)
		{
			using (AppData db = new AppData())
			{
				foreach (var item in doc.Purchases)
				{
					item.PaymentDocId = doc.Id;
					// It is ok to write complex code which writes a complex entity to db.
					db.Entry(item).State = item.Id == 0 ? System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;
					//db.Entry(item.Directory).State = System.Data.Entity.EntityState.Unchanged;
				}

				db.Entry(doc).State = doc.Id == 0 ? System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;

				db.SaveChanges();
			}
		}

		public static void Delete(PaymentDoc doc)
		{
			if (doc.Id == 0) return;
			int doc_id = doc.Id;

			using (AppData db = new AppData())
			{
				var d = db.PaymentDocs.Include("Purchases").FirstOrDefault(x => x.Id == doc_id);
				if (d == null) return;

				db.Purchases.RemoveRange(d.Purchases);

				db.Entry(d).State = System.Data.Entity.EntityState.Deleted;

				db.SaveChanges();
			}
		}
	}
}
