using Costs.Presenters.Views;
using Costs.Views;

namespace Costs.Forms
{
	public interface IFormsFactory
	{
		IDocumentsForm CreateDocumentsView();
		IEditDocumentView CreateEditDocumentView();
		IPurchaseView CreatePurchaseView();
		IDialogMessages CreateDialogMessages();
	}
}