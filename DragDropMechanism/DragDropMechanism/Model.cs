using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragDropMechanism
{
	public class Model
	{
		List<ProductType> productTypes { get; } = new List<ProductType>();
		List<Product> products { get; } = new List<Product>();
		List<Category> categories { get; } = new List<Category>();
		public Model()
		{
			categories.Add(new Category {Name = "Мясо", Id = 1 });
			categories.Add(new Category {Name = "Сладкое", Id = 2 });
			categories.Add(new Category {Name = "Сладкое1", Id = 3 });
			categories.Add(new Category {Name = "Сладкое2", Id = 4 });

			productTypes.Add(new ProductType { Name = "Говядина", CategoryId = 1});
			productTypes.Add(new ProductType { Name = "Курица", CategoryId = 1 });
			productTypes.Add(new ProductType { Name = "Свинина", CategoryId = 1 });
			productTypes.Add(new ProductType { Name = "Конфеты", CategoryId = 2 });
			productTypes.Add(new ProductType { Name = "Шоколад", CategoryId = 2 });

			foreach (var item in productTypes)
			{
				var c = categories.FirstOrDefault(x=>x.Id == item.CategoryId);
				c.Items.Add(item);
			}
		}
		public IEnumerable<ProductType> ProductTypes { get { return productTypes; } }
		public IEnumerable<Product> Products { get { return products; } }
		public IEnumerable<Category> Categories { get { return categories; } }
		public Category CurrentCategory { get; set; }
		public void AddProduct(ProductType t)
		{
			products.Add(new Product { Name = $"{t.Name} - продукт"});
		}
	}
}
