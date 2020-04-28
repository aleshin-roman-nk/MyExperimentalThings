using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrRomic.Dialogs
{
    public static class InputBox
    {
        public static string GetText(string title, string init_text = null)
        {
            IMainView view = new InputStringForm();
            return view.GetText(title, init_text);
        }
    }
}
