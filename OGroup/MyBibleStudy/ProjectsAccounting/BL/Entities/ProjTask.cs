using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsAccounting.BL.Entities
{
	public class ProjTask
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public decimal Hours { get; set; }
		public int ProjectId { get;set; }
		public List<Session> Sessions { get; set; } = new List<Session>();
	}
}
