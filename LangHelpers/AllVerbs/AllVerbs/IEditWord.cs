using AllVerbs.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllVerbs
{
	public interface IEditWord
	{
		string Present { get; set; }
		string Past { get; set; }
		string Perfect { get; set; }
		UserAnswer Go();
	}
}
