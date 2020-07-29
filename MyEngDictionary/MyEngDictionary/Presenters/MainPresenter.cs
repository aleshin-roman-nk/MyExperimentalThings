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

		public MainPresenter(IMainView mv)
		{
			_mainView = mv;
		}
	}
}