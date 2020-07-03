using MultiPtesenterExp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Идея в том, что весь контроль по получению данных и их сохранение лежит в MainPresenter
 * Так что все рабочие экземпляры моделей бизнесс логики лежат в MainPresenter. Или создаются в нужный момент.
 * Но как быть с разнообразнием IView.
 * 
 * 
 * >>>
 * 26-06-2020 20:23
 * Реализуем немножко другое
 *	главный view имеет в интерфейсе вложенные части, которые реализуют UserControl
 *	Должно получиться что то вроде
 *		interface IView
 *		{
 *			IView1 View1 { get; }
 *			IView1 View2 { get; }
 *		}
 *	Теперь презентер имеет части. И каждая соответсвующая часть берет view.View1
 *		Как то так
 *		presenter1 = new Presenter1(view.View1);
 *		
 *	Таким образом необходимо следовать спецификации именования
 *		Части презентера в конце имеют слово Part (например ManagerPresenterPart)
 *		Простые презентеры просто имя сущность плюс слово Presenter (например MainPresenter)
 *		
 *	
 */

namespace MultiPtesenterExp.Presenters
{
	public class MainPresenter
	{
		IMainView _mainView;
		readonly ManagerPresenterPart managerPresenterPart;

		public MainPresenter(IMainView mainView)
		{
			_mainView = mainView;

			managerPresenterPart = new ManagerPresenterPart(_mainView.ManagersViewPart);
		}

	}
}
