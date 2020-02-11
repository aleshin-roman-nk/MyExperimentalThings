using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyProtocol.BL.Entities
{
	public enum ItemType { start, stop, pause, resume}

	public class MarkerItem
	{
		public int Id { get; set; }
		public ItemType ItemType { get; set; }
		public string Comment { get; set; }
		public DateTime DateTime { get; set; }
		public int WorkId { get; set; }
	}
}
