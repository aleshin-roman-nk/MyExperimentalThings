using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

/*
 * >>> 29.07.2020 16:01
 * 
 * Сделать карточки слов.
 * Отношение многие ко многим joining table
 * 
 * 
 */

namespace MyEngDictionary.BL.Entities
{
	public class Phrase
	{
		public int Id { get; set; }
		public string TextEng { get; set; }
		public string TextRus { get; set; }
		public PhraseType PhraseType { get;set;}
		public string Examples { get; set; }// Возможно это хранить в отдельном файле, а поле ссылается на файл
		public bool IsKnown { get; set; }
	}
}
