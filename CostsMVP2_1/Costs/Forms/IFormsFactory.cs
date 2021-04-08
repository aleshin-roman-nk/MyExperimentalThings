using Costs.Presenters.Views;
using Costs.Views;

namespace Costs.Forms
{
	public interface IFormsFactory
	{
		IDocumentsView CreateDocumentsView();
		IEditDocumentView CreateEditDocumentView();
		IEditPurchaseView CreatePurchaseView();
		IDialogMessages CreateDialogMessages();
		IMainView CreateMainView();
		IShopView CreateShopsView();
	}
}