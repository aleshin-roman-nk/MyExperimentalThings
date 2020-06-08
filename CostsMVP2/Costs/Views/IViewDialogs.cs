using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costs.Presenters.Views
{
	public interface IViewDialogs
	{
		void ShowError(string msg, string title);
		bool UserAnsweredYes(string msg, string title);
	}
}
