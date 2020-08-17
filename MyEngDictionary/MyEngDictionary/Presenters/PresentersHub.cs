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
		void Register(EventType eventType, Func<object, ViewResult<object>> f);
		ViewResult<object> Publish(EventType eventType, object p);
		IPresenterHub AddPresenter(IPresenter p);
	}

	public interface IPresenter
	{
		void Register(IPresenterHub hub);
	}

	public class PresenterHub : IPresenterHub
	{
		Dictionary<EventType, Func<object, ViewResult<object>>> events = new Dictionary<EventType, Func<object, ViewResult<object>>>();
		public void Register(EventType eventType, Func<object, ViewResult<object>> f)
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

		public IPresenterHub AddPresenter(IPresenter p)
		{
			p.Register(this);

			return this;
		}
	}

	public enum EventType { Create, Update, Delete, SelectPhrasePack }
}
