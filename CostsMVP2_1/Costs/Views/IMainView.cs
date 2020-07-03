using Costs.Domain.Entities;
using Costs.Entities;
using Costs.Presenters.Views.EventArgs;
using Costs.Views.EventArgs;
using Costs.Views.Parts;
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


		/*
		 * >>> 02-07-2020 15:48
		 * Главная польза такого решения (вкладывать view, которые реализуют готовые UserControl)
		 *	- можно делать сборки, конфигурировать MainView
		 *	Это необходимо в данном случае, например нужно выводить одну и ту же информацию в разных окнах.
		 */
		IPurchasesViewPart PurchasesView { get; }
		IDirectoriesViewPart DirectoriesView { get; }
		IDateSelector DateSelector { get; }

		event Action CreateDocumentCmd;
	}
}
