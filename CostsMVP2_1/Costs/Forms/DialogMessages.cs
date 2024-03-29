﻿using Costs.DlgService;
using Costs.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Costs.Forms
{
	// Это сервисные диалоги, можно отделить от обычных view
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
		public bool UserAnsweredYes(string msg)
		{
			return Messages.UserAnsweredYes(msg, "");
		}
	}
}
