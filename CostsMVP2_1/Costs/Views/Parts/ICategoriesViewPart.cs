using Costs.Domain.Entities;
using Costs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costs.Views.Parts
{
	public interface ICategoriesViewPart
	{
		void SetProductTypes(IEnumerable<ProductType> items);
		void SetCategories(IEnumerable<Category> categs);

		Category CurrentCategory { get; }

		event Action<Category> UpdateProductTypes;
		event Action UpdateCategories;
		event Action CommandCreateCategory;
		event Action<Category> CommandCreateProductType;
		event Action<Category> CommandDeleteCategory;
		event Action<ProductType> CommandDeleteProductType;
		event Action<ProductType> CommandAddPointToDoc;
	}
}
