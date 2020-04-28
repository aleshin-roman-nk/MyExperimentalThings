using Costs.BL.Models;
using Costs.Entities;
using Costs.Models;
using Costs.Presenters.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costs.Presenters
{
	public class ProductTypePresenter
	{
		List<ProductType> products;
		ISampleProductsView view;
		ProductTypeModel model;

		public ProductTypePresenter(ISampleProductsView v)
		{
			model = new ProductTypeModel();
			view = v;

			products = new List<ProductType>();
			reloadSampleProducts();

			view.AddProduct += View_AddProduct;
			view.RemoveProduct += View_RemoveProduct;
			view.SetProducts(products);

			view.SetPresenter(this);
		}

		private void View_RemoveProduct(ProductType obj)
		{
			if(view.UserAnsweredYes($"Подтвердите удаление {obj.Name}", "Удаление"))
			{
				model.RemoveProduct(obj);
				reloadSampleProducts();
			}
		}

		private void View_AddProduct(string obj)
		{
			if (!string.IsNullOrWhiteSpace(obj))
			{
				model.WriteProduct(new ProductType { Name = obj });
				reloadSampleProducts();
			}
		}

		public void Run()
		{
			view.Show();
		}

		private void reloadSampleProducts()
		{
			products.Clear();
			products.AddRange(model.GetProducts());
			view.SetProducts(products);
		}
	}
}
