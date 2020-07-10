using Costs.BL.Models;
using Costs.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costs.Presenters.Parts
{
	public class DocumentsViewPresenterPart
	{
		IDocumentsForm _view;
		PayDocumentsModel _documentsMode;

		public DocumentsViewPresenterPart(IDocumentsForm v)
		{
			_view = v;
			_documentsMode = new PayDocumentsModel();

			_view.EditDocumentCmd += _view_EditDocumentCmd;
		}

		private void _view_EditDocumentCmd(object sender, BL.Domain.Entities.PaymentDoc e)
		{
			EditDocumentPresenter pres = new EditDocumentPresenter();
			_view.SetDocuments(_documentsMode.GetDocumentsOfMonth(d.Year, d.Month));
		}

		public void Run()
		{
			var d = DateTime.Now;
			_view.SetDocuments(_documentsMode.GetDocumentsOfMonth(d.Year, d.Month));
			_view.Go();
		}
	}
}
