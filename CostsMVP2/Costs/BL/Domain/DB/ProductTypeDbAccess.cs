using Costs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costs.DB
{
	/*
	 * Отсек обращения к БД чтение, запись.
	 * 
	 * Отсек вычислений, обработки, сборки сущностей.
	 * 
	 * 
	 */


	/*
	 * Вот так маленькими частями вроде хорошо писать.
	 * 
	 * 
	 */


	/// <summary>
	/// Общий ридер из базы
	/// </summary>
	public class ProductTypeDbAccess
	{
		public static List<ProductType> Read()
		{
			List<ProductType> list = null;

			using (AppData db = new AppData())
			{
				list = db.ProductTypes.OrderBy(x => x.Name).ToList();
			}
			return list;
		}

		public static void Write(ProductType ent)
		{
			using (AppData db = new AppData())
			{
				db.Entry(ent).State = ent.ID == 0 ? System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;
				db.SaveChanges();
			}
		}

		public static bool Remove(ProductType ent)
		{
			bool removed = false;

			using (AppData db = new AppData())
			{
				db.Entry(ent).State = System.Data.Entity.EntityState.Deleted;
				db.SaveChanges();

				removed = true;
			}

			return removed;
		}

	}
}
