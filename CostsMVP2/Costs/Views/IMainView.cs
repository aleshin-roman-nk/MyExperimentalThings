using Costs.Domain.Entities;
using Costs.Entities;
using Costs.Presenters.Views.EventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* Вьюшка получает данные для отображения.
* Пользователь воздействует на вьюшку, срабатывают события, вьюшка оповещает клиента о изменениях
*/

namespace Costs.Presenters.Views
{
	public interface IMainView
	{
		// Позволяет как угодно отображать дерево. Различные внутренние модули типа TreeViewDirectoryKeys предоставляют логику вывода
		void SetDirectories(IEnumerable<Directory> dirList);
		void SetPurchases(IEnumerable<Purchase> ppList);
		void SetPurchasesAmount(decimal amount);
		void SetProductTypes(IEnumerable<ProductType> items);
		void SetCategories(IEnumerable<Category> categs);

		void ShowError(string msg);
		bool UserAnsverYes(string msg);

		Directory CurrentDirectory { get; }
		DateTime CurrentDate { get; }
		Category CurrentCategory { get; }
		bool OneDay { get; }

		event Action<ProductType, DateTime> CreatePurchase;
		event Action<Purchase> EditPurchase;
		event Action<Purchase> DeletePurchase;
		event Action<Purchase, Directory> MovePurchase;
		event Action<Category> UpdateProductTypes;
		event Action UpdateCategories;
		event Action<string> BtnCreateCategory;
		event Action<string, Category> BtnCreateProductType;
		event Action<Category> BtnDeleteCategory;
		event Action<ProductType> BtnDeleteProductType;

		//event Action CurrentDirectoryChanged;
		event Action<PurchaseFilterChangedEventArg> ValuesChanged;
		event Action<Directory, Directory> MoveDirectory;
		event Action<Directory> BtnCreateDirectory;
		event Action<Directory> BtnRenameDirectory;
		event Action<Directory> BtnDeleteDirectory;

		event Action BtnCreatePayDocs;
	}
}
