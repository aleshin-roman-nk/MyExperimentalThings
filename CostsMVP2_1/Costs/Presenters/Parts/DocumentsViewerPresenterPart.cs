using Costs.BL.Domain.Entities;
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
	public class DocumentsViewerPresenterPart
	{
		IFormsFactory _factory;
		IDocumentsView _documentsView;
		PayDocumentsModel _documentsMode;

		// >>> 10-07-2020 21:17
		// We can pass IFormsFactory
		public DocumentsViewerPresenterPart(IFormsFactory f)
		{
			_factory = f;
			_documentsMode = new PayDocumentsModel();

			_documentsView = _factory.CreateDocumentsView();
			_documentsView.EditDocumentRequired += _view_EditDocumentRequired;
			_documentsView.PeriodChanged += _documentsView_PeriodChanged;
			_documentsView.CurrentChanged += _documentsView_CurrentChanged;
		}

		private void _documentsView_CurrentChanged(object sender, PaymentDoc e)
		{
			_documentsView.SetAmount(e.Amount);
		}

		private void _documentsView_PeriodChanged(object sender, Costs.Views.EventArgs.PeriodChangedEventArg e)
		{
			_documentsView.SetDocuments(getDocuments(e.Date, e.OneMonth));
		}

		private void _view_EditDocumentRequired(object sender, PaymentDoc e)
		{
			EditDocumentPresenter pres = new EditDocumentPresenter(_factory);
			pres.Run(e);

			_documentsView.SetDocuments(_documentsMode.GetDocumentsOfMonth(_documentsView.Date.Year, _documentsView.Date.Month));
		}

		private IEnumerable<PaymentDoc> getDocuments(DateTime date, bool oneMonth)
		{
			IEnumerable<PaymentDoc> docs;

			if (oneMonth)
				docs = _documentsMode.GetDocumentsOfMonth(date.Year, date.Month);
			else
				docs = _documentsMode.GetDocumentsOfDay(date.Year, date.Month, date.Day);

			return docs;
		}

		public void Run()
		{			
			var d = DateTime.Now;
			_documentsView.SetDocuments(getDocuments(d, true));
			_documentsView.Date = d;
			_documentsView.Go();
		}
	}
}
