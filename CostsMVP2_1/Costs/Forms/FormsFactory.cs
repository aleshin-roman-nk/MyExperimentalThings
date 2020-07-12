using Costs.Forms.PayDocumentsForm;
using Costs.Presenters.Views;
using Costs.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costs.Forms
{
	public class FormsFactory : IFormsFactory
	{
		public IPurchaseView CreatePurchaseView()
		{
			return new EditPurchaseForm();
		}
		public IDocumentsForm CreateDocumentsView()
		{
			return new DocumentsForm();
		}
		public IEditDocumentView CreateEditDocumentView()
		{
			return new EditDocumentForm();
		}

		public IDialogMessages CreateDialogMessages()
		{
			return new DialogMessages();
		}
	}
}
