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
		void SetDirectories(List<Directory> dirList);
		void SetPurchases(List<Purchase> ppList);
		void SetPurchasesAmount(decimal amount);
		void SetProductTypes(IEnumerable<ProductType> items);
		void SetCategories(IEnumerable<Category> categs);

		void ShowError(string msg);
		bool UserAnsverYes(string msg);

		Directory CurrentDirectory { get; }

		DateTime CurrentDate { get; }

		bool OneDay { get; }
		Category CurrentCategory { get; }

		event Action<ProductType, DateTime> CreatePurchase;
		event Action<Purchase> EditPurchase;
		event Action<Purchase> DeletePurchase;
		event Action<Purchase, Directory> MovePurchase;
		event Action<Category> GetProductTypes;
		event Action GetCategories;
		event Action<string> BtnCreateCategory;
		event Action<string, Category> BtnCreateProductType;
		event Action<Category> BtnDeleteCategory;
		event Action<ProductType> BtnDeleteProductType;

		//event Action CurrentDirectoryChanged;
		event Action<MainViewValuesChangedEventArg> ValuesChanged;
		event Action<Directory, Directory> MoveDirectory;
		event Action<Directory> BtnCreateDirectory;
		event Action<Directory> BtnRenameDirectory;
		event Action<Directory> BtnDeleteDirectory;
	}
}
