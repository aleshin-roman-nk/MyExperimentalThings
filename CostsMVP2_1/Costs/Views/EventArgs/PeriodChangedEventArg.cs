using System;

namespace Costs.Views.EventArgs
{
	public class PeriodChangedEventArg
	{
		public PeriodChangedEventArg(DateTime date, bool one_month)
		{
			Date = date;
			OneMonth = one_month;
		}

		public DateTime Date;
		public bool OneMonth { get; private set; }
	}
}
