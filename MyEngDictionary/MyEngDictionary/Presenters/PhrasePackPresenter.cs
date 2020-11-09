using DialCommuna.FormResult;
using MyEngDictionary.BL.DBA;
using MyEngDictionary.BL.Entities;
using MyEngDictionary.BL.Models;
using MyEngDictionary.Forms;
using MyEngDictionary.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * >>> 26-07-2020 22:31
 * Идея архитектуры MVP
 * - как бы подмодель, содержащаяся в слое presenter, которая хранит состояние локальной модели.
 *	view события изменений влияют на эту локальную модель, в этой локальной модели кэшируются изменения сущностей.
 * 
 * Главный вопрос - решить, как отслеживать и фиксировать изменения данных, который обслуживает view.
 *	Вариант 1.
 *		Кнопка начать изменения, отменить изменения, сохранить изменения.
 * https://stackoverflow.com/questions/6248992/does-presenter-in-model-view-presenter-create-views/6431252#6431252
 * 
 * https://codereview.stackexchange.com/questions/51823/using-models-and-entities-in-mvp-pattern
 * 
 * >>> 29-07-2020 12:52
 * 
 * 
 * >>> 06-08-2020 08:30
 * !!! Грамматический паттерн + словарный запас = практика.
 * Нужно как то совмещать раздел грамматики и словарный запас, включая идиомы и обороты.
 * 
 * >>> 06-08-2020 09:33
 * !!! Грамматичесие паттерны - отдельное окно с объяснением и упражнениями.
 * 

 * 
 * 
 * >>> 07-08-2020 09:47
 * Добавить в проект теги к словам, которые относят слово к какой то тему. Например тема рыбалка, програмирование.
 * Это отдельная таблица сущностей связок.
 * 
 * 
 * >>> 09-08-2020 22:25
 * В первую очередь нужно проработать функционал окон, архитектуру интерфейса пользователя.
 * Что нужно объекту User. Только потом думать над внутренней частью.
 * 
 */


/*
 * >>> 08-08-2020 14:59
 * !!!
 * MainPresenter вообще то что то типа общего презентера, типа управляющего другими. Другие конкретные презентеры и view должны иметь конкретные имена.
 * 
 */
namespace MyEngDictionary.Presenters
{
	public class PhrasePackPresenter: IPresenter
	{
		IPhrasePackView _phrasePackView;
		PhrasePackModel _phrasePackModel;
		IPresenterHub _hub;

		public PhrasePackPresenter(IPhrasePackView mv)
		{
			_phrasePackView = mv;
			_phrasePackModel = new PhrasePackModel();

			_phrasePackView.PhraseCRUDRequset += _phrasePackView_PhraseCRUDRequset;
			_phrasePackView.ChangeCurrentPack += _phrasePackView_ChangeCurrentPack;
			_phrasePackView.ClosingView += _phrasePackView_Closing;

			_phrasePackModel.LoadLastPhrasePack();

			updateView();
		}

		private void _phrasePackView_ChangeCurrentPack(object sender, EventArgs e)
		{

			var res = _hub.Publish(EventType.SelectPhrasePack, null);

			if (res.Answer == ViewAnswer.Ok)
			{
				_phrasePackModel.PhrasePack = res.Data as PhrasePack;
				_phrasePackView.SetPhrasePack(_phrasePackModel.PhrasePack);
			}
			else
			{
				if (!_phrasePackModel.PhrasePackExists(_phrasePackModel.PhrasePack.Id))
				{
					_phrasePackModel.LoadLastPhrasePack();
					_phrasePackView.SetPhrasePack(_phrasePackModel.PhrasePack);
				}
			}
		}

		private void _phrasePackView_Closing(object sender, ViewResult e)
		{
			if (DialCommuna.Dialogs.UserAnswerYes.Show("Имеются несохраненные изменения. Подтвердите закрытие", "Завершение"))
				e.Answer = ViewAnswer.Ok;
		}

		private void _phrasePackView_PhraseCRUDRequset(object sender, CRUDRequest<Phrase> e)
		{
			if(e.CRUDCode == CRUDType.Create)
			{
				var res = DialCommuna.Dialogs.InputText.Show("Введите новую фразу");
				if (res.Answer == ViewAnswer.Ok)
				{
					_phrasePackModel.AddPhrase(res.Data, PhraseType.Word);
					_phrasePackModel.Save();
					updateView();
				}
			}
			else if(e.CRUDCode == CRUDType.Update)
			{
				_phrasePackModel.Save();
				updateView();
			}
			else if(e.CRUDCode == CRUDType.Delete)
			{
				if(DialCommuna.Dialogs.UserAnswerYes.Show($"Подтвердите удаление слова/фразы '{e.Data.TextEng}'", "Удаление"))
				{
					_phrasePackModel.Delete(e.Data);
					updateView();
				}
			}
		}

		private void updateView()
		{
			_phrasePackView.SetWordCount(GeneralModel.PhraseCount);
			_phrasePackModel.Reload();
			_phrasePackView.SetPhrasePack(_phrasePackModel.PhrasePack);
		}

		public void Init(IPresenterHub hub)
		{
			// Запоминаем ссылу, куда отправлять запрос.
			_hub = hub;
		}

		/*
		 * >>> 01-08-2020 12:15
		 * Локализовать точки извлечения данных из бд и запись в бд
		 */
	}
}