using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsAccounting.BL.Entities
{
	public class Week
	{
		public DateTime DateOfMonday { get; set; }
		public string Name { get; set; }
		public List<ProjTask> ProjTasks { get; set; }
	}
}
