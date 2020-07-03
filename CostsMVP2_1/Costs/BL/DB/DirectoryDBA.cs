using Costs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costs.DB
{
	public class DirectoryDBA
	{
		/// <summary>
		/// Возвращает плоскую коллекцию директорий, относительно root, включая root. Если root == null возвращает всю коллекцию
		/// </summary>
		/// <param name="root"></param>
		/// <returns></returns>
		public static IEnumerable<Directory> ReadAll()
		{
			using (AppData db = new AppData())
			{
				return db.Directories.ToList();
			}
		}

		public static void Save(Directory dir)
		{
			using (AppData db = new AppData())
			{
				db.Entry(dir).State = dir.ID == 0 ? System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;
				db.SaveChanges();
			}
		}

		public static bool HasChildren(Directory parent)
		{
			using (AppData db = new AppData())
			{
				return !(db.Directories.FirstOrDefault(x => x.ParentID == parent.ID) == default(Directory));
			}
		}

		public static bool HasPurchases(Directory parent)
		{
			using (AppData db = new AppData())
			{
				return !(db.Purchases.FirstOrDefault(x => x.DirectoryID == parent.ID) == default(Purchase));
			}
		}

		public static void Delete(Directory dir)
		{
			using (AppData db = new AppData())
			{
				db.Entry(dir).State = System.Data.Entity.EntityState.Deleted;
				db.SaveChanges();
			}
		}
	}
}
