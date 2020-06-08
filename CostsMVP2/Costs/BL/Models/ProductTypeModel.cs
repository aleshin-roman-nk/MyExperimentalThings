using Costs.DB;
using Costs.Domain.Entities;
using Costs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costs.BL.Models
{
	public class ProductTypeModel
	{
		public List<ProductType> GetProductTypesByName(string name = null)
		{
			if (string.IsNullOrEmpty(name)) return ProductTypeDbAccess.Read().OrderBy(x => x.Name).ToList();

			return ProductTypeDbAccess.Read()
				.Where(x => x.Name.ToUpper()
				.Contains(name.ToUpper()))
				.OrderBy(x => x.Name).ToList();
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
		public IEnumerable<ProductType> ProductTypes()
		{
			using (AppData db = new AppData())
			{
				return db.ProductTypes.OrderBy(x => x.Name).ToList();
			}
		}
		public IEnumerable<ProductType> ProductTypes(Category c)
		{
			using (AppData db = new AppData())
			{
				return db.ProductTypes.Where(x=>x.CategoryId == c.Id).OrderBy(x => x.Name).ToList();
			}
		}
		public void SaveCategory(Category cat)
		{
			using (AppData db = new AppData())
			{
				db.Entry(cat).State = cat.Id == 0 ? System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;
				db.SaveChanges();
			}
		}
		public void SaveProductType(ProductType pt)
		{
			using (AppData db = new AppData())
			{
				db.Entry(pt).State = pt.ID == 0 ? System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;
				db.SaveChanges();
			}
		}

		public void DeleteProductType(ProductType pt)
		{
			using (AppData db = new AppData())
			{
				db.Entry(pt).State = System.Data.Entity.EntityState.Deleted;
				db.SaveChanges();
			}
		}
		public void DeleteCategory(Category cat)
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
		public void WriteProduct(ProductType product)
		{
			ProductTypeDbAccess.Write(product);
		}
		public bool RemoveProduct(ProductType product)
		{
			return ProductTypeDbAccess.Remove(product);
		}
		public List<ProductType> GetProducts()
		{
			return ProductTypeDbAccess.Read();
		}

	}
}
