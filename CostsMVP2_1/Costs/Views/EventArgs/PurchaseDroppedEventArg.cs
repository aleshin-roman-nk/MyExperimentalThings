﻿using Costs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costs.Views.EventArgs
{
	public class PurchaseDroppedEventArg
	{
		public PurchaseDroppedEventArg(Purchase what, Directory desc)
		{
			What = what;
			Desc = desc;
		}

		public Purchase What { get; }
		public Directory Desc { get; }
	}
}