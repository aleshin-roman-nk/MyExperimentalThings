using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * >>> 29-07-2020 22:23
 * Слово имеет ссылки на слова на другом языке. Применяется joining table
 * Слово имеет поле объяснения.
 * Слово имеет поле упражнения.
 * 
 * По привеленным выше данным строим сущность информации о слове.
 *	Слова эквиваленты на другом языке
 *	Объяснение
 *	Практические упражнения (составленные предложения)
 * 
 */

namespace MyEngDictionary.BL.Entities.UI
{
	public class PhraseCardUI
	{
		public int Id { get; set; }
		public int PhraseId { get; set; }
		public string Phrase { get; set; }
		public string Explanation { get; set; }
		public string Exercises { get; set; }
		public ICollection<Phrase> PhrasesEqu { get; } = new List<Phrase>();
	}
}
