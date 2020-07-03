using Costs.Entities;
using Costs.Models;
using Costs.Presenters.Views;
using Costs.Views.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * >>> 02-07-2020 15:27
 * Появилась необходимость обмена этого презентера с главным презентером.
 * Когда view сообщает о том что упал ProductType, то нужно создать Purchase.
 *	Для того, чтобы создать Purchase нужно знать дату, документ.
 *	
 *	В главном окне IPurchasesViewPart:
 *		- показ списка покупок
 *		- показ суммы
 *	В окне работы документ:
 *		- показ списка покупок
 * 		- показ суммы
 * 		- 
 * Похоже на не нужен отдельный презентер для каждого UserControl
 *	Решения делать вложенные IXXXViewPart достаточно.
 * 
 */

namespace Costs.Presenters.Parts
{
	public class PurchasesPresenterPart
	{
		IPurchasesViewPart _view;
		PurchasesModel _purchModel;

		public PurchasesPresenterPart(IPurchasesViewPart view)
		{
			_view = view;
			_purchModel = new PurchasesModel();

			//_view.ProductTypeDropped += ;
			_view.DeletePurchaseCmd += _view_DeletePurchaseCmd;
			_view.EditPurchaseCmd += _view_EditPurchaseCmd;
		}

		private void _view_EditPurchaseCmd(Purchase obj)
		{
			throw new NotImplementedException();
		}

		private void _view_DeletePurchaseCmd(Purchase obj)
		{
			throw new NotImplementedException();
		}
	}
}
