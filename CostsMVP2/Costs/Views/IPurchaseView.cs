using Costs.Entities;
using Costs.Presenters.Views.EventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costs.Presenters.Views
{
	public interface IPurchaseView
	{
		void SetDirectoryName(string dirName);
		void SetPurchase(Purchase purchase);
		Purchase GetPurchase();

		event Action<string, List<ProductType>> RequestSampleProductList;
	}
}