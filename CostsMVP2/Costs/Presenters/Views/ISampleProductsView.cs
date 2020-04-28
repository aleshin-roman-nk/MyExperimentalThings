using Costs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costs.Presenters.Views
{
	public interface ISampleProductsView: IView<ProductTypePresenter>, IViewDialogs
	{
		string ProductName { get; }
		void SetProducts(List<ProductType> list);

		event Action<string> AddProduct;
		event Action<ProductType> RemoveProduct;

		void Show();
	}
}
