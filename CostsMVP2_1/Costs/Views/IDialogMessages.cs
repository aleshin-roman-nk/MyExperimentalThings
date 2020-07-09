using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costs.Views
{
	public interface IDialogMessages
	{
		void ShowError(string msg);
		bool UserAnsweredYes(string msg);
		string InputText(string init_text, string title = null);
	}
}
