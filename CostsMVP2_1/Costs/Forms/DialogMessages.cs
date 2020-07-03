using Costs.DlgService;
using Costs.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Costs.Forms
{
	public class DialogMessages : IDialogMessages
	{
		public string InputText(string init_text, string title = null)
		{
			return Messages.InputText(init_text, title);
		}
		public void ShowError(string msg)
		{
			Messages.ShowError(msg, "");
		}
		public bool UserAnswerYes(string msg)
		{
			return Messages.UserAnsweredYes(msg, "");
		}
	}
}
