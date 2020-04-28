using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costs.Presenters.Views
{
	public interface IViewsContainer
	{
		IMainView MainView { get; }
		IPurchaseView PurchaseView { get; }
	}
}
