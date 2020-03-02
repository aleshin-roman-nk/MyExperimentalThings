using DrRomic.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrRomic.UI
{
	/*
	 * >>>
	 * 20-02-2020 11-50
	 * Основные подходы реализации очереди объектов:
	 *		1. Связанный список
	 *		2. Массив объектов, перемещение между которыми посредством изменения текущего индекса.
	 * 
	 * >>>
	 * Кроме идеи составного компонента grid + panel, может доктрина, что каждому типу объекта соответствует своя панель,
	 *		включающая и сетку и панель(ли).
	 *	
	 * >>>
	 * Система команд.
	 *		* Таблица команд содержится в маршрутизаторе
	 *		* Маршрутизатор находится между презентером и моделями
	 *			Как определить обратный ответ?
	 *		
	 *		Другой вариант - если много панелек с множеством запросов, нажатий команд,
	 *			тогда маршрутизация - часть механизма внутри части IView.
	 * 
	 * ******************************************
	 * 
	 * Нажатие пункта таблицы
	 * Вход в объект
	 *	Параметры объекта -> запрос на содержимое этого объекта
	 *	Имеем загруженный объект, в которого хотим войти
	 *	Привязать данные и отобразить панель работы с содержимым объекта, в которого вошли
	 * 
	 * 
	 * 
	 * 
	 */

	public class PanelController
	{
		IGridPanel gridPanel;
		List<IPanel> panels = new List<IPanel>();
		int pos = 0;

		public event Action<string> OnMessage;
		public event Action<Requset> OnRequest;

		public void SetGridPanel(IGridPanel gp)
		{
			gridPanel = gp;
			gridPanel.Next += GridPanel_Next;
			gridPanel.Back += GridPanel_Back;
		}
		public void Add(IPanel panel)
		{
			panel.OnMessage += Panel_OnMessage;
			panel.OnRequest += Panel_OnRequest;
			panels.Add(panel);
		}
		public void TurnFirst()
		{
			pos = 0;
			gridPanel.Clear();
			panels[pos].Enter(null);
			gridPanel.Attach(panels[pos]);
		}

		private void Panel_OnRequest(Requset obj)
		{
			OnRequest?.Invoke(obj);
		}
		private void Panel_OnMessage(string obj)
		{
			OnMessage?.Invoke(obj);
		}
		private void GridPanel_Back()
		{
			if (IsFirst) return;
			gridPanel.Clear();

			panels[pos].Leave();
			pos--;
			panels[pos].EnterBack();
			gridPanel.Attach(panels[pos]);
		}
		private void GridPanel_Next()
		{
			if (!HasNext) return;
			gridPanel.Clear();

			var o = panels[pos].Leave();
			pos++;
			panels[pos].Enter(o);
			gridPanel.Attach(panels[pos]);
		}
		private bool HasNext { get { return pos < panels.Count - 1; } }
		private bool IsFirst { get { return pos == 0; } }
	}
}
