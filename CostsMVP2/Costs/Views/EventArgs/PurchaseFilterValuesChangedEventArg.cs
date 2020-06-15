using Costs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costs.Presenters.Views.EventArgs
{
	public class PurchaseFilterChangedEventArg
	{
		public PurchaseFilterChangedEventArg(DateTime dt, Directory Dir, bool oneMonth)
		{
			Date = dt;
			Directory = Dir;
			this.OneDay = oneMonth;
		}

		public DateTime Date { get; set; }
		public Directory Directory { get; set; }
		public bool OneDay { get; set; }
	}
}
