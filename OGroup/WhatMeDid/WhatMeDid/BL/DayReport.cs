using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatMeDid.BL
{
	public class DayReport: IDayNotation
	{
		public int Id { get; set; }
		public DateTime DateTime { get; set; }
		public string Body { get; set; }
	}
}
