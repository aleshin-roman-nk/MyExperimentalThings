using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			var p = getDirection(new Point(0,0), new Point(5, 10));

			var arad = getAngle(10, 10);
			var a = arad * (180.0 / Math.PI);
			//Console.WriteLine(p.ToString()); ;
			Console.WriteLine(a.ToString()); ;

			Console.ReadLine();
		}

		static double getAngle(float dx, float dy)
		{
			return  Math.Atan(dy / dx);
		}

		static PointF getDirection(Point p0, Point p1)
		{
			double x = p1.X - p0.X;
			double y = p1.Y - p0.Y;

			double g = Math.Sqrt(x * x + y * y);

			return new PointF
			{
				X = Convert.ToSingle(x / g),
				Y = Convert.ToSingle(y / g)
			};
		}
	}


}
