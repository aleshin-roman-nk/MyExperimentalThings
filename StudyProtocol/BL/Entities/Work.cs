using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyProtocol.BL.Entities
{
	public class Work
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public int WorkDayId { get; set; }
		public List<MarkerItem> MarkerItems { get; set; } = new List<MarkerItem>();
	}
}
