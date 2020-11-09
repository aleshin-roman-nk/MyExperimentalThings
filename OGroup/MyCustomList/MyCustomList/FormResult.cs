using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCustomList
{
	public enum FormResultCode { Ok = 1, Cancel = 2}

	public class FormResult
	{
		public FormResultCode ResultCode { get; set; }

		public FormResult(FormResultCode code)
		{
			ResultCode = code;
		}
	}
}
