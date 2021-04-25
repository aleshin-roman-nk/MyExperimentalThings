using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costs.Views
{
	public interface IInputDateTimeView
	{
		DateTime UserDateTime { get; }
		void Go();
	}
}
