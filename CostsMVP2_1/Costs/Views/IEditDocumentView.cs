using Costs.BL.Domain.Entities;
using Costs.Domain.Entities;
using Costs.Entities;
using Costs.Presenters.Views.EventArgs;
using Costs.Views.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costs.Views
{
	public interface IEditDocumentView
	{
		// Позволяет как угодно отображать дерево. Различные внутренние модули типа TreeViewDirectoryKeys предоставляют логику вывода
		DateTime CurrentDateTime { get; set; }
		ViewResult GetResult();
		string Shop { get; set; }
		IPurchasesViewPart PurchasesView { get; }
		IDirectoriesViewPart DirectoriesView { get; }
		ICategoriesViewPart CategoriesView { get; }

		event EventHandler ShopNameRequested;
	}
}
