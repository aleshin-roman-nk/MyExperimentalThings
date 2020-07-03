using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiPtesenterExp.Views
{
	public interface IManagersViewPart
	{
		string NameB { get; }
		string NameA { get; }
		int Salary { get; }
		event Action ShowCmd;
	}
}
