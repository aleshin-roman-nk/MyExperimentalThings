using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEngDictionary.BL.Entities
{
	public class PhraseLinker
	{
		public int Id { get; set; }
		public int PhraseEngId { get; set; }
		public int PhraseRusId { get; set; }
	}
}