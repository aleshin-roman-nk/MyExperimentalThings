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
			if (string.IsNullOrEmpty(name)) return ProductTypeDBA.Read().OrderBy(x => x.Name).ToList();

			return ProductTypeDBA.Read()
				.Where(x => x.Name.ToUpper()
				.Contains(name.ToUpper()))
				.OrderBy(x => x.Name).ToList();
		}
		public IEnumerable<ProductType> ProductTypes()
		{
			using (AppData db = new AppData())
			{
				return db.ProductTypes.OrderBy(x => x.Name).ToList();
			}
		}
		public IEnumerable<ProductType> GetProductTypes(Category c)
		{
			using (AppData db = new AppData())
			{
				return db.ProductTypes.Where(x=>x.CategoryId == c.Id).OrderBy(x => x.Name).ToList();
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

		public void Save(ProductType product)
		{
			ProductTypeDBA.Save(product);
		}
		public bool Delete(ProductType product)
		{
			return ProductTypeDBA.Remove(product);
		}
		public IEnumerable<ProductType> GetProductTypes()
		{
			return ProductTypeDBA.Read();
		}

	}
}
