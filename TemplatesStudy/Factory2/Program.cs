using System;

namespace Factory2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
		}
	}

	public abstract class PizzaStore
	{
		public Pizza orderPizza(string type)
		{
			Pizza pizza = createPizza(type);

			pizza.Prepare();
			pizza.Bake();
			pizza.Cut();
			pizza.Box();

			return pizza;
		}

		public abstract Pizza createPizza(string type);
	}


	public class PeppironiPizza : Pizza
	{
	}

	public class GreekPizza : Pizza
	{
	}

	public class CheesePizza : Pizza
	{
	}

	public class Pizza
	{
		public void Bake()
		{
			throw new NotImplementedException();
		}

		public void Box()
		{
			throw new NotImplementedException();
		}

		public void Cut()
		{
			throw new NotImplementedException();
		}

		public void Prepare()
		{
			throw new NotImplementedException();
		}
	}
}
