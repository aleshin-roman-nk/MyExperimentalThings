using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEngDictionary.BL.Entities
{
	public class Sentence
	{
		public int Id { get; set; }
		public int PhraseId { get; set; }
		public string Text { get; set; }
	}
}
