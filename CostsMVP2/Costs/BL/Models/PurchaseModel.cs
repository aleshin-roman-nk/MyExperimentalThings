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
		public List<ProductType> GetProductTypesByName(string name = null)
		{
			if (string.IsNullOrEmpty(name)) return ProductTypeDbAccess.Read().OrderBy(x => x.Name).ToList();

			return ProductTypeDbAccess.Read()
				.Where(x => x.Name.ToUpper()
				.Contains(name.ToUpper()))
				.OrderBy(x => x.Name).ToList();
		}
		public Directory GetDirectory(int dirID)
		{
			return DirectoryModel.GetDirectory(dirID);
		}
		public static void MoveToDir(Purchase item, Directory toDir)
		{
			item.DirectoryID = toDir.ID;
			item.Directory = toDir;

			using (AppData db = new AppData())
			{
				db.Entry(item).State = System.Data.Entity.EntityState.Modified;
				db.SaveChanges();
			}
		}
		public static void DeletePurchase(Purchase p)
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
