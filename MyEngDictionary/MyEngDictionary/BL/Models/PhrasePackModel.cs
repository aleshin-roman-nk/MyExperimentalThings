using MyEngDictionary.BL.DBA;
using MyEngDictionary.BL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * >>> 06-08-2020 11:22
 * Модель работы с текущим набором фраз
 * Сколько слов в моем словарном запасе можно узнать отдельно. Или указывать где-нибудь в углу формы.
 *	Либо выводом всех слов в словаре.
 * 
 * 
 * >>> 06-08-2020 23:59
 * Работа с одной сущностью, текущей, которая выбрана пользователем.
 * Создание, удаление, обновление (сохранение изменений).
 * 
 * Работа с коллекцией.
 * 
 * Сущность PhrasePack
 * В главном окне работа только с этой сущностью
 * Во вспомогательном окне выбор пакета слов.
 * 
 * Функции окна коллекции PhrasePacks
 *	- создание группы
 *	- удаление группы (при этом фразы группы остаются)
 *	- выбор текущей группы
 *	- добавлять слово в пакет
 *	- удалять слово из пакета
 *	
 * 
 * >>> 07-08-2020 00:07
 * Лучше применять ui сущности и модели к ним.
 * тогда прослойка сборки этих сущностей.
 * Скажем сущность PhrasePack
 * Модель PhrasePackModel для работы с одной сущностью
 * 
 * >>> 09-08-2020 01:09
 * Разделить именно выбор пакета и окно создания и компоновки пакета.
 * Таким образом будут два разных окна.
 * Окна, не требующие сложной обработки (окно выбора из списка например) используются без презентера.
 * 
 * 
 */


namespace MyEngDictionary.BL.Models
{

	/*
	 * >>> 21-08-2020 00:36
	 * Одна модель обслуживает один презентер, который обслуживает один view.
	 * Если модель слишком сложная, разделить ее на вспомогательные логические части.
	 * 
	 */
	public class PhrasePackModel
	{
		public PhrasePack PhrasePack { get; set; }

		public PhrasePackModel()
		{
			LoadLastPhrasePack();
		}

		public void AddPhrase(string text, PhraseType phraseType)
		{
			PhrasePack.Phrases.Add(new Phrase { TextEng = text, PhraseType = phraseType});
		}

		public void Delete(Phrase p)
		{
			PhraseDBA.Delete(p);
		}

		public void Save()
		{
			PhrasePack.LastWrite = DateTime.Now;
			PhrasePackDBA.Save(PhrasePack);
		}

		public void Reload()
		{
			PhrasePack = PhrasePackDBA.Get(PhrasePack.Id);
		}

		public void LoadLastPhrasePack()
		{
			// именно через property чтобы возбуждать event
			PhrasePack = PhrasePackDBA.GetLastPhrasePack();
		}

		public bool PhrasePackExists(int id)
		{
			return PhrasePackDBA.PhrasePackExists(id);
		}
	}
}
