using MyEngDictionary.BL.Entities;
using MyEngDictionary.BL.Models;
using MyEngDictionary.Utilites;
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
 * 
 */

namespace MyEngDictionary.Presenters
{
	public class MainPresenter
	{
		IMainView _mainView;
		IPhrasesModel _model;

		public MainPresenter(IMainView mv, IPhrasesModel phrasesModel)
		{
			_mainView = mv;
			_model = phrasesModel;

			_mainView.PhraseChanged += _mainView_PhraseChanged;
			_mainView.CreatePhrase += _mainView_CreatePhrase;

			_mainView.SetPhrases(_model.GetPhrases());
			_mainView.SetWordCount(_model.WordsCount);
		}

		private void _mainView_CreatePhrase(object sender, EventArgs e)
		{
			var res = DialCommuna.Dialogs.InputText.Show("Введите новую фразу");
			if(res.Answer == DialCommuna.FormResult.ViewAnswer.Ok)
			{
				var i = _model.Create(res.Data);
				_model.Save(i);
				_mainView.SetPhrases(_model.GetPhrases());
				_mainView.SetWordCount(_model.WordsCount);
			}
		}

		/*
		 * >>> 01-08-2020 12:15
		 * Локализовать точки извлечения данных из бд и запись в бд
		 */

		private void _mainView_PhraseChanged(object sender, Phrase e)
		{
			_mainView.SetWordCount(_model.WordsCount);
		}
	}
}