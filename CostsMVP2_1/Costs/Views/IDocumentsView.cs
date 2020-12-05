using Costs.BL.Domain.Entities;
using Costs.Views.EventArgs;
using System;
using System.Collections.Generic;

namespace Costs.Views
{
	public interface IDocumentsView
	{
		event EventHandler<PeriodChangedEventArg> PeriodChanged;
		event EventHandler<PaymentDoc> EditDocumentRequired;
		event EventHandler<PaymentDoc> CurrentChanged;
		event Action<PaymentDoc> DeletePayDocument;
		void SetDocuments(IEnumerable<PaymentDoc> docs);
		void SetAmount(decimal am);
		void Go();

		DateTime Date { get; set; }
	}
}