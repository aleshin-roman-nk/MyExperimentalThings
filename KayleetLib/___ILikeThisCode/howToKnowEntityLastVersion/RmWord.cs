using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllVerbs.BL
{
	public class RmWord
	{
		public int Id { get; set; }
		public string V1 { get; set; }
		public string V2 { get; set; }
		public string V3 { get; set; }
		public int RmTagId { get; set; }
		public string Exercises { get; set; }

		public DateTime receivedfromdb;
	}
}
