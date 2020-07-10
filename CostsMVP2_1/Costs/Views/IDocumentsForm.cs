using Costs.BL.Domain.Entities;
using Costs.Views.EventArgs;
using System;
using System.Collections.Generic;

namespace Costs.Views
{
	public interface IDocumentsForm
	{
		event EventHandler<PeriodChangedEventArg> PeriodChanged;
		event EventHandler<PaymentDoc> EditDocumentCmd;
		void SetDocuments(IEnumerable<PaymentDoc> docs);
		void Go();
	}
}