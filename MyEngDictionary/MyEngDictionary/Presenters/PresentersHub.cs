using DialCommuna.FormResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEngDictionary.Presenters
{
	public interface IPresenterHub
	{
		void RegisterCommand(EventType eventType, Func<object, ViewResult<object>> f);
		ViewResult<object> Publish(EventType eventType, object p);
		IPresenterHub JoinMe(IPresenter p);
	}

	public interface IPresenter
	{
		void Init(IPresenterHub hub);
	}

	// >>> 08-11-2020 16:45
	#region Презентеры сервер и клиент. Один презентер может реализовать и клиент и сервер
	public interface IPresenterClient
	{

	}

	public interface IPresenterServer
	{

	}
	#endregion

	public class PresenterHub : IPresenterHub
	{
		Dictionary<EventType, Func<object, ViewResult<object>>> events = new Dictionary<EventType, Func<object, ViewResult<object>>>();
		public void RegisterCommand(EventType eventType, Func<object, ViewResult<object>> f)
		{
			if (events.ContainsKey(eventType)) return;

			events[eventType] = f;
		}

		public ViewResult<object> Publish(EventType eventType, object p)
		{
			if (!events.ContainsKey(eventType)) return null;
			var res = events[eventType](p);
			return res;
		}

		//--- мы НЕ добавляем презентер, а только
		// один клиент. все остальные - исполнители
		// и возможны одновременно и исполнители и клиенты.
		// как работать с мелкими окошками?
		// кстати, можно попробовать использовать эту тактику комуникации p-v.
		//	Но там уже есть альт. - это одно событие запроса. и именно объект запроса - команда с паараметрами.
		public IPresenterHub JoinMe(IPresenter p)
		{
			p.Init(this);

			return this;
		}
	}

	public enum EventType { Create, Update, Delete, SelectPhrasePack }
}
