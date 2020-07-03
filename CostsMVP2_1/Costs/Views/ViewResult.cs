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
		public ResponseCode Answer { get; }

		public ViewResult( T obj, ResponseCode sign )
		{
			Result = obj;
			Answer = sign;
		}
	}

	public class ViewResult
	{
		public ResponseCode Answer { get; }

		public ViewResult(ResponseCode sign)
		{
			Answer = sign;
		}
	}

	public enum ResponseCode { Ok, Cancel}
}
