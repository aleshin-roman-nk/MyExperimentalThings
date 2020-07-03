using Costs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costs.Views.EventArgs
{
	public class CreatePurchaseEventArg
	{
		public ProductType ProductType { get; set; }
		public DateTime Date { get; set; }

		public CreatePurchaseEventArg(ProductType ptype, DateTime pdate)
		{
			ProductType = ptype;
			Date = pdate;
		}
	}
}
