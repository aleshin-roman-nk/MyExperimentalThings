using Costs.Presenters.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costs.Forms
{
	public static class FormsFactory
	{
		public static IPurchaseView CreatePurchaseView()
		{
			return new EditPurchaseForm();
		}
	}
}
