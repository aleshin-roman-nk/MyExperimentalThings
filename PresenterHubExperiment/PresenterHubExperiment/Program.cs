using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresenterHubExperiment
{
	class Program
	{
		static void Main(string[] args)
		{
			PresenterA pa = new PresenterA();
			PresenterB pb = new PresenterB();
			IPresenterHub hub = new PresenterHub();
			hub.AddPresenter(pa);
			hub.AddPresenter(pb);

			pb.Run();

			Console.ReadLine();
		}
	}

	interface IPresenterHub
	{
		void Register(EventType eventType, Func<object, object> f);
		object Publish(EventType eventType, object p);
		void AddPresenter(IPresenter p);
	}

	class PresenterHub: IPresenterHub
	{
		Dictionary<EventType, Func<object, object>> events = new Dictionary<EventType, Func<object, object>>();
		public void Register(EventType eventType, Func<object, object> f)
		{
			if (events.ContainsKey(eventType)) return;

			events[eventType] = f;
		}

		public object Publish(EventType eventType, object p)
		{
			if (!events.ContainsKey(eventType)) return null;

			return events[eventType](p);
		}

		public void AddPresenter(IPresenter p)
		{
			p.Register(this);
		}
	}

	enum EventType { Create, Update, Delete }

	interface IPresenter
	{
		void Register(IPresenterHub hub);
	}

	class PresenterA: IPresenter
	{
		public PresenterA()
		{
			
		}

		public void Register(IPresenterHub hub)
		{
			hub.Register(EventType.Create, func);
		}

		object func(object o)
		{
			return $"I am PresenterA. Hey {o}";
		}
	}

	class PresenterB: IPresenter
	{
		IPresenterHub _hub;

		public PresenterB()
		{
			
		}

		public void Register(IPresenterHub hub)
		{
			_hub = hub;
		}

		public void Run()
		{
			var res = _hub.Publish(EventType.Create, "Roman");
			Console.WriteLine(res);
		}
	}
}
