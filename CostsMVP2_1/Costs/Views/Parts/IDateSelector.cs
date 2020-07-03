using Costs.Views.EventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costs.Views.Parts
{
	public interface IDateSelector
	{
		bool OneMonth { get; }
		DateTime CurrentDate { get; }

		event Action<PeriodChangedEventArg> ValuesChanged;
	}
}
