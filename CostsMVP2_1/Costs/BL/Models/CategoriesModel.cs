using Costs.Domain.Entities;
using Costs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costs.BL.Models
{
	public class CategoriesModel
	{
		public void Save(Category cat)
		{
			using (AppData db = new AppData())
			{
				db.Entry(cat).State = cat.Id == 0 ? System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;
				db.SaveChanges();
			}
		}

		public void Delete(Category cat)
		{
			using (AppData db = new AppData())
			{
				var pts = db.ProductTypes.Where(x => x.CategoryId == cat.Id).ToList();
				foreach (var item in pts)
				{
					db.Entry(item).State = System.Data.Entity.EntityState.Deleted;
				}
				db.Entry(cat).State = System.Data.Entity.EntityState.Deleted;

				db.SaveChanges();
			}
		}

		public IEnumerable<Category> Categories
		{
			get
			{
				using (AppData db = new AppData())
				{
					return db.Categories.OrderBy(x => x.Name).ToList();
				}
			}
		}
	}
}
