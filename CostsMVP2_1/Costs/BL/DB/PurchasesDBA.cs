using Costs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costs.DB
{
	public class PurchasesDBA
	{
		//public static IEnumerable<Purchase> Read(Directory root_dir, DateTime dt1, DateTime dt2)
		public static IEnumerable<Purchase> Read(IEnumerable<Directory> dirs, DateTime dt1, DateTime dt2)
		{
			//var dirCollection = DirectoryDBA.Read(root_dir);

			var result = new List<Purchase>();

			using (AppData db = new AppData())
			{
				//foreach (var dir in dirCollection)
				foreach (var dir in dirs)
					result.AddRange(db.Purchases.Where(x => x.DirectoryID == dir.ID && (x.Date >= dt1) && (x.Date <= dt2)).ToList());
			}

			return result;
		}
		public static void Save(Purchase ent)
		{
			using (AppData db = new AppData())
			{
				//*1
				//db.Purchases.Attach(ent);
				db.Entry(ent).State = ent.Id == 0 ? System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;
				// if don't line *1, then:
				//db.Entry(ent.SampleProduct).State = System.Data.Entity.EntityState.Unchanged;
				db.SaveChanges();
			}
		}
		public static void Delete(Purchase p)
		{
			if (p == null) return;

			using (AppData db = new AppData())
			{
				db.Entry(p).State = System.Data.Entity.EntityState.Deleted;
				db.SaveChanges();
			}
		}
	}
}
