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
	public class DocumentsViewerPresenter
	{
		IFormsFactory _factory;
		IDocumentsView _documentsView;
		PayDocumentsModel _documentsMode;

		DateTime currentDate;
		bool oneMonth = true;

		// >>> 10-07-2020 21:17
		// We can pass IFormsFactory
		public DocumentsViewerPresenter(IFormsFactory f)
		{
			_factory = f;
			_documentsMode = new PayDocumentsModel();

			_documentsView = _factory.CreateDocumentsView();
			_documentsView.EditDocumentRequired += _view_EditDocumentRequired;
			_documentsView.PeriodChanged += _documentsView_PeriodChanged;
			_documentsView.CurrentChanged += _documentsView_CurrentChanged;
			_documentsView.DeletePayDocument += _documentsView_DeletePayDocument;
		}

		private void _documentsView_DeletePayDocument(PaymentDoc obj)
		{
			var q = _factory.CreateDialogMessages();

			if(q.UserAnsweredYes($"Документ {obj.Title} будет удален. Подтвердите"))
			{
				_documentsMode.Delete(obj);
				_documentsView.SetDocuments(getDocuments(currentDate, oneMonth));
			}
		}

		private void _documentsView_CurrentChanged(object sender, PaymentDoc e)
		{
			_documentsView.SetAmount(e.Amount);
		}

		private void _documentsView_PeriodChanged(object sender, Costs.Views.EventArgs.PeriodChangedEventArg e)
		{
			currentDate = e.Date;
			oneMonth = e.OneMonth;
			_documentsView.SetDocuments(getDocuments(currentDate, oneMonth));
		}

		private void _view_EditDocumentRequired(object sender, PaymentDoc e)
		{
			EditDocumentPresenter pres = new EditDocumentPresenter(_factory);
			pres.Run(e);

			_documentsView.SetDocuments(_documentsMode.GetDocumentsOfMonth(_documentsView.Date.Year, _documentsView.Date.Month));
		}

		/*
		 * >>> 20-11-2020 19:44
		 * Вместо DateTime date, bool oneMonth думаю лучше практиковать нормальные запросы
		 * к данным в виде цельного объекта с параметрами. Хотя в таком случае расплодится миллион
		 * классов. Или можно сделать универсальное решение....
		 * 
		 */
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
			/*
			 * >>> 27 - 11 - 2020 21:24
			 * Возможно удобно состояние хранить в обтельном блоке, который находится в презентере.
			 * 
			 */

			currentDate = DateTime.Now;
			oneMonth = true;

			_documentsView.SetDocuments(getDocuments(currentDate, oneMonth));
			_documentsView.Date = currentDate;
			_documentsView.Go();
		}
	}
}
