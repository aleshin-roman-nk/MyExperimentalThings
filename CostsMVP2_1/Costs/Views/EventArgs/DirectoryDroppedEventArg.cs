using Costs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costs.Views.EventArgs
{
	public class DirectoryDroppedEventArg
	{
		public DirectoryDroppedEventArg(Directory what, Directory desc )
		{
			What = what;
			Desc = desc;
		}

		public Directory What { get; }
		public Directory Desc { get; }
	}
}
