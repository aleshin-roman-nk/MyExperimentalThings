using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalkOnDirs.BL
{
	public class Directory
	{
		public int Id { get; set; }
		public int ParentId { get; set; }
		public string Name { get; set; }
	}
}
