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
			Dropped = what;
			Desc = desc;
		}

		public Directory Dropped { get; }
		public Directory Desc { get; }
	}
}
