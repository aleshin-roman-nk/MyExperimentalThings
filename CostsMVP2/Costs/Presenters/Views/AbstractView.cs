using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costs.Presenters.Views
{
	public class AbstractView<TPresenter>
		where TPresenter: class, new()
	{
		TPresenter presenter;

		public void SetPresenter(TPresenter p)
		{
			presenter = p;
		}
	}
}