using Costs.BL.DB;
using Costs.BL.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costs.BL.Models
{
	public class PayDocumentsModel
	{
		public IEnumerable<PaymentDoc> GetDocumentsOfMonth(int year, int month)
		{
			DateTime from = new DateTime(year, month, 1, 0, 0, 0, 0);
			int days = DateTime.DaysInMonth(year, month);
			DateTime to = new DateTime(year, month, days, 23, 59, 59, 999);

			return PayDocumentDBA.GetPaymentDocs(from, to);
		}
		public IEnumerable<PaymentDoc> GetDocumentsOfDay(int year, int month, int day)
		{
			DateTime from = new DateTime(year, month, day, 0, 0, 0, 0);
			DateTime to = new DateTime(year, month, day, 23, 59, 59, 999);

			return PayDocumentDBA.GetPaymentDocs(from, to);
		}

		public void Delete(PaymentDoc doc)
		{
			PayDocumentDBA.Delete(doc);
		}
	}
}
