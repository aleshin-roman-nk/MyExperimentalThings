using Costs.BL.Entities;
using Costs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costs.BL.DB
{
	public class ShopsDBA
	{
		public static IEnumerable<Shop> Get()
		{
			using (AppData db = new AppData())
			{
				return db.Shops.ToList();
			}
		}
		public static void Delete(Shop s)
		{
			using (AppData db = new AppData())
			{
				db.Entry(s).State = System.Data.Entity.EntityState.Deleted;
				db.SaveChanges();
			}
		}
		public static void Save(Shop s)
		{
			using (AppData db = new AppData())
			{
				db.Entry(s).State = s.Id == 0 ? System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;
				db.SaveChanges();
			}
		}
	}
}
