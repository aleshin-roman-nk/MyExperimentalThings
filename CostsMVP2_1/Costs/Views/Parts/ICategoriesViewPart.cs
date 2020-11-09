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
		event Action CreateCategoryCmd;
		event Action<Category> CreateProductTypeCmd;
		event Action<Category> DeleteCategoryCmd;
		event Action<ProductType> DeleteProductTypeCmd;
		event Action<ProductType> AddPointToDoc;
	}
}
