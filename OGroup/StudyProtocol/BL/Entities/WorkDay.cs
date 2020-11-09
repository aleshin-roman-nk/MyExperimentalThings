using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyProtocol.BL.Entities
{
	public class WorkDay
	{
		public int Id { get; set; }
		public DateTime Date { get; set; }
		public string SourceFile { get; set; }
		public List<Work> Works { get; set; } = new List<Work>();
	}
}
