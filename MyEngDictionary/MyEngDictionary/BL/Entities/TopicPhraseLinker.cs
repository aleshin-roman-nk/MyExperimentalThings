using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEngDictionary.BL.Entities
{
	public class TopicPhraseLinker
	{
		public int Id { get; set; }
		public int PhraseId { get; set; }
		public int TopicId { get; set; }
	}
}
