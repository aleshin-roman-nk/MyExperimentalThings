using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiPtesenterExp.Presenters
{
	public interface IPresenterWithResult<T>
		where T: class
	{
		PresenterResult<T> Run(T obj);
	}
}
