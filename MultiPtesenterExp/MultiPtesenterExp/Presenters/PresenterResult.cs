using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiPtesenterExp.Presenters
{
	public class PresenterResult<T>
	{
		public T Result { get; }
		public ResultStatus Status { get; }

		public PresenterResult( T resobj, ResultStatus status )
		{
			Result = resobj;
			Status = status;
		}

	}
	public enum ResultStatus { Ok = 0, Error = 1, Cancel = 2}
}
