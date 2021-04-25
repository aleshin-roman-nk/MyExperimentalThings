using System;
using System.Collections.Generic;

namespace TemplatesStudy
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");



			Console.ReadLine();
		}
	}

	internal class PizzaStore
	{
		SimplePizzaFactory factory;

		public PizzaStore(SimplePizzaFactory f)
		{
			this.factory = f;
		}

		public Pizza orderPizza(string type)
		{
			Pizza pizza = factory.create(type);

			pizza.Prepare();
			pizza.Bake();
			pizza.Cut();
			pizza.Box();

			return pizza;
		}
	}

	internal class SimplePizzaFactory
	{
		public Pizza create(string type)
		{
			Pizza pizza = null;

			if (type.Equals("cheese"))
				pizza = new CheesePizza();
			else if (type.Equals("greek"))
				pizza = new GreekPizza();
			else if (type.Equals("peppironi"))
				pizza = new PeppironiPizza();

			return pizza;
		}
	}

	internal class PeppironiPizza : Pizza
	{
	}

	internal class GreekPizza : Pizza
	{
	}

	internal class CheesePizza : Pizza
	{
	}

	internal class Pizza
	{
		internal void Bake()
		{
			throw new NotImplementedException();
		}

		internal void Box()
		{
			throw new NotImplementedException();
		}

		internal void Cut()
		{
			throw new NotImplementedException();
		}

		internal void Prepare()
		{
			throw new NotImplementedException();
		}
	}
}
