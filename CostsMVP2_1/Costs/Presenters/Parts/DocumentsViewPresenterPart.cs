using Costs.BL.Models;
using Costs.Forms;
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
		IFormsFactory _factory;
		IDocumentsForm _documentsView;
		PayDocumentsModel _documentsMode;

		// >>> 10-07-2020 21:17
		// We can pass IFormsFactory
		public DocumentsViewPresenterPart(IFormsFactory f)
		{
			_factory = f;
			_documentsMode = new PayDocumentsModel();
		}

		private void _view_EditDocumentCmd(object sender, BL.Domain.Entities.PaymentDoc e)
		{
			//EditDocumentPresenter pres = new EditDocumentPresenter();
			//_view.SetDocuments(_documentsMode.GetDocumentsOfMonth(d.Year, d.Month));
		}

		public void Run()
		{
			_documentsView = _factory.CreateDocumentsView();
			_documentsView.EditDocumentCmd += _view_EditDocumentCmd;

			var d = DateTime.Now;
			_documentsView.SetDocuments(_documentsMode.GetDocumentsOfMonth(d.Year, d.Month));
			_documentsView.Go();
		}
	}
}
