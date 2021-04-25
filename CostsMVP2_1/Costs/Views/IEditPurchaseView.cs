using Costs.Entities;
using Costs.Presenters.Views.EventArgs;
using Costs.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costs.Presenters.Views
{
	public interface IEditPurchaseView
	{
		void SetDirectoryName(string dirName);
		void SetPurchase(Purchase purchase);
		ViewResult<Purchase> GetResult();
	}
}