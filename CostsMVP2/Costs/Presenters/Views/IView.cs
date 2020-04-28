using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costs.Presenters.Views
{
	public interface IView<TPresenter>
	{
		void SetPresenter(TPresenter presenter);
	}
}
