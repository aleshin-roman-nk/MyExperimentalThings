using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costs.Views
{
	public class ViewResult<T>
	{
		public T Result { get; }
		public Answer Answer { get; }

		public ViewResult( T obj, Answer sign )
		{
			Result = obj;
			Answer = sign;
		}
	}

	public class ViewResult
	{
		public Answer Answer { get; }

		public ViewResult(Answer sign)
		{
			Answer = sign;
		}
	}

	public enum Answer { Ok, Cancel}
}
