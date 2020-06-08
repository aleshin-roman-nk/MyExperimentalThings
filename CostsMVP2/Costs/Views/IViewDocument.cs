using Costs.BL.Domain.Entities;
using Costs.Domain.Entities;
using Costs.Entities;
using Costs.Presenters.Views.EventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costs.Views
{
	public interface IViewDocument
	{
		// Позволяет как угодно отображать дерево. Различные внутренние модули типа TreeViewDirectoryKeys предоставляют логику вывода
		void SetDirectories(List<Directory> dirList);

		void SetProductTypes(IEnumerable<ProductType> items);
		void SetCategories(IEnumerable<Category> categs);
		void SetDoc(PaymentDoc doc);

		void ShowError(string msg);
		bool UserAnsverYes(string msg);
		bool ShowForm();

		Directory CurrentDirectory { get; }
		DateTime CurrentDate { get; }
		Category CurrentCategory { get; }

		event Action<ProductType, DateTime> CreatePurchase;
		event Action<Purchase> EditPurchase;
		event Action<Purchase> DeletePurchase;
		event Action<Purchase, Directory> MovePurchase;

		event Action<Category> ProductTypesRequired;
		event Action CategoriesRequired;

		event Action<string> BtnCreateCategory;
		event Action<string, Category> BtnCreateProductType;
		event Action<Category> BtnDeleteCategory;
		event Action<ProductType> BtnDeleteProductType;

		event Action<DateTime, Directory> ValuesChanged;

		event Action<Directory, Directory> MoveDirectory;
		event Action<Directory> BtnCreateDirectory;
		event Action<Directory> BtnRenameDirectory;
		event Action<Directory> BtnDeleteDirectory;
	}
}
