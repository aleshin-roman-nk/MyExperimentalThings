using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialCommuna.FormResult
{

	public class ViewResult
	{
		public ViewAnswer Answer { get; set; }
	}

	public class ViewResult<T>
	{
		public ViewAnswer Answer { get; set; }
		public T Data { get; set; }
	}

	public enum ViewAnswer { Ok, Cancel }
}
