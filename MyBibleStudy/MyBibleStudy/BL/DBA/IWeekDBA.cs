using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vedeg.BL.DBA
{
	public interface IWeekDBA
	{
		IEnumerable<Week> GetAll();
		void SaveAll();
	}
}
