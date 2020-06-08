using Costs.DB;
using Costs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costs.Models
{
	public class PurchaseModel
	{
		List<Purchase> purchases = new List<Purchase>();
		public IEnumerable<Purchase> Purchases { get => purchases; }
		public decimal Amount { get => purchases.Sum(x => x.Amount); }

		public void SavePurchase(Purchase p)
		{
			PurchasesDB.Write(p);
		}

		public void ReloadPurchases(Directory directory, DateTime dt, bool one_day)
		{
			reloadPurchases(directory, dt, one_day);
		}
		private void reloadPurchases(Directory directory, DateTime dt, bool one_day)
		{
			purchases.Clear();
			purchases.AddRange(PurchasesDB.Read(directory, dt, one_day));
		}

		public void MoveToDir(Purchase item, Directory toDir)
		{
			item.DirectoryID = toDir.ID;
			item.Directory = toDir;

			using (AppData db = new AppData())
			{
				db.Entry(item).State = System.Data.Entity.EntityState.Modified;
				db.SaveChanges();
			}
		}
		public void DeletePurchase(Purchase p)
		{
			if (p == null) return;

			using (AppData db = new AppData())
			{
				db.Entry(p).State = System.Data.Entity.EntityState.Deleted;
				db.SaveChanges();
			}
		}
		public Purchase CreatePurchase(DateTime dt)
		{
			return new Purchase { Date = dt, Count = 1.0M, Price = 0.0M };
		}
	}
}
