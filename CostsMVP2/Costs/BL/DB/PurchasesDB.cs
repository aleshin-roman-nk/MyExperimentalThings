using Costs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costs.DB
{
	public class PurchasesDB
	{
		public static List<Purchase> Read(Directory directory, DateTime dt, bool one_day)
		{
			var dirCollection = DirectoryDB.Read(directory);

			var result = new List<Purchase>();
			
			DateTime dt0;
			DateTime dt1;
			int totaldays = DateTime.DaysInMonth(dt.Year, dt.Month);

			if (one_day)
			{
				dt0 = new DateTime(dt.Year, dt.Month, dt.Day, 0, 0, 0, 0);
				dt1 = new DateTime(dt.Year, dt.Month, dt.Day, 23, 59, 59, 999);
			}
			else
			{
				dt0 = new DateTime(dt.Year, dt.Month, 1, 0, 0, 0, 0);
				dt1 = new DateTime(dt.Year, dt.Month, totaldays, 23, 59, 59, 999);
			}

			using (AppData db = new AppData())
			{
				foreach (var dir in dirCollection)
					result.AddRange(db.Purchases.Include("Directory").Where(x => x.DirectoryID == dir.ID && (x.Date >= dt0) && (x.Date <= dt1)).ToList());
			}

			return result;
		}
		public static void Write(Purchase ent)
		{
			using (AppData db = new AppData())
			{
				//*1
				db.Purchases.Attach(ent);
				db.Entry(ent).State = ent.Id == 0 ? System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;
				// if don't line *1, then:
				//db.Entry(ent.SampleProduct).State = System.Data.Entity.EntityState.Unchanged;
				db.SaveChanges();
			}
		}
	}
}
