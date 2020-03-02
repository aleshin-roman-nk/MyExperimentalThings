using MoneyAccouting.BL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyAccouting.BL.Models
{
	public class ProductsModel
	{
		public IEnumerable<Product> GetProducts(int year, int month)
		{
			throw new NotImplementedException();
		}

		public Product CreateProduct(DateTime date, Category cat, ProductType ptype)
		{
			return new Product
			{
				CategoryId = cat.Id,
				Name = ptype.Name,
				Date = date,
				Count = 1,
				Price = 0
			};
		}

		public void SaveProduct(Product prod)
		{

		}

		public IEnumerable<Category> GetCategories()
		{
			throw new NotImplementedException();
		}

		public IEnumerable<ProductType> GetProductTypes()
		{
			throw new NotImplementedException();
		}
	}
}
