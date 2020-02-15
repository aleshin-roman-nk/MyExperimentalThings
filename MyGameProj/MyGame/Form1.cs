using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MyGame
{
	public partial class Form1 : Form
	{
		private List<WObject> wObjects = new List<WObject>();
		private WObject selected = null;
		
		public Form1()
		{
			InitializeComponent();
			
			wObjects.Add(new WObject(myPaintBox1, Brushes.Red, ServFunctions.GetRandomPoint(myPaintBox1.Width, myPaintBox1.Height), ServFunctions.GetNumber(1, 15)));
			wObjects.Add(new WObject(myPaintBox1, Brushes.Gold, ServFunctions.GetRandomPoint(myPaintBox1.Width, myPaintBox1.Height), ServFunctions.GetNumber(1, 15)));
			wObjects.Add(new WObject(myPaintBox1, Brushes.Gray, ServFunctions.GetRandomPoint(myPaintBox1.Width, myPaintBox1.Height), ServFunctions.GetNumber(1, 15)));
			//wObjects.Add(new WObject(myPaintBox1, Brushes.Aqua, ServFunctions.GetRandomPoint(myPaintBox1.Width, myPaintBox1.Height)));
			//wObjects.Add(new WObject(myPaintBox1, Brushes.Blue, ServFunctions.GetRandomPoint(myPaintBox1.Width, myPaintBox1.Height)));
			//wObjects.Add(new WObject(myPaintBox1, Brushes.Chocolate, ServFunctions.GetRandomPoint(myPaintBox1.Width, myPaintBox1.Height)));
			//wObjects.Add(new WObject(myPaintBox1, Brushes.Chartreuse, ServFunctions.GetRandomPoint(myPaintBox1.Width, myPaintBox1.Height)));
			//wObjects.Add(new WObject(myPaintBox1, Brushes.DarkKhaki, ServFunctions.GetRandomPoint(myPaintBox1.Width, myPaintBox1.Height)));
			//wObjects.Add(new WObject(myPaintBox1, Brushes.BlueViolet, ServFunctions.GetRandomPoint(myPaintBox1.Width, myPaintBox1.Height)));
			//wObjects.Add(new WObject(myPaintBox1, Brushes.DarkOrchid, ServFunctions.GetRandomPoint(myPaintBox1.Width, myPaintBox1.Height)));
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			myPaintBox1.Invalidate();
		}

		private void myPaintBox1_Paint(object sender, PaintEventArgs e)
		{
			e.Graphics.Clear(Color.White);

			e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

			Font drawFont = new Font("Consolas", 16);
			SolidBrush drawBrush = new SolidBrush(Color.Black);

			List<WObject> tmp = new List<WObject>();
			foreach (var item in wObjects)
			{
				item.Move();
				item.Draw(e.Graphics);

				if (item.DivideNeeded)
				{
					//var o = new WObject(myPaintBox1, item.brush, ServFunctions.GetRandomPoint(myPaintBox1.Width, myPaintBox1.Height));
					var o = new WObject(myPaintBox1, item.brush, item.Position, item.speed);
					tmp.Add(o);
					item.rad = 10;
				}
			}

			if (tmp.Count > 0)
				wObjects.AddRange(tmp);

			int line = 0;
			foreach (var item in wObjects.OrderByDescending(x => x.count))
			{
				e.Graphics.DrawString($"{line + 1}. Rad : {item.rad}, speed: {item.speed}", drawFont, item.brush, 20, line * drawFont.Height);
				line++;
			}

			drawSelectedRect(e.Graphics);
			DrawTable(e.Graphics, 20, 30, 4, 5);
		}

		private void drawSelectedRect(Graphics gr)
		{
			if (selected == null) return;

			Pen p = new Pen(Brushes.LightGreen, 3);
			gr.DrawRectangle(p, selected.Position.X - selected.rad, selected.Position.Y - selected.rad, selected.rad * 2, selected.rad * 2);
		}

		private void DrawTable(Graphics gr, int posx, int posy, int cols, int rows)
		{
			int colWidth = 100;
			int rowHeght = 30;

			Pen p = new Pen(Brushes.LightGray);

			for (int col_i = 0; col_i < cols + 1; col_i++)
			{
				gr.DrawLine(p,
					posx + col_i * colWidth,
					posy,
					posx + col_i * colWidth,
					posy + rows * rowHeght);

				for (int row_i = 0; row_i < rows + 1; row_i++)
				{
					gr.DrawLine(p,
						posx,
						posy + row_i * rowHeght,

						posx + cols * colWidth,
						posy + row_i * rowHeght);
				}
			}
		}

		private WObject GetAt(PointF p)
		{
			return wObjects.FirstOrDefault(x => isInCircle(p, x.Position, x.rad));
		}

		private bool isInCircle(PointF p, PointF pos, int rad)
		{
			return (Math.Abs(pos.X - p.X) <= rad) && (Math.Abs(pos.Y - p.Y) <= rad);
		}

		private void myPaintBox1_MouseDown(object sender, MouseEventArgs e)
		{
			selected = GetAt(new PointF(e.X, e.Y));

			//targetA = new Point(e.X, e.Y);

			//dirA = getDirection(a, targetA);

			//stepA = new PointF
			//{
			//	X = dirA.X * speedA,
			//	Y = dirA.Y * speedA
			//};
		}
	}

	/*
	 * Попробовать сделать свои миграции, автоматическое создание новой таблицы sqlite используя низкоуровневое API
	 *
	 */

	// попробовать создать свою UI на основе myPaintBox1 с особенностью возможности рисовать схемы с биндингом
	//		необычные графические блоки, создание составных отображаемых структур которые можно наполнять данными, из базы данных

	internal class Selection
	{
	}

	internal interface IShape
	{
		Point Size { get; set; }
		Point Pos { get; set; }
	}

	internal static class ServFunctions
	{
		private static Random rnd = new Random();

		public static Point GetRandomPoint(int width, int hight)
		{
			return new Point(rnd.Next(width), rnd.Next(hight));
		}

		public static int GetNumber(int from, int to)
		{
			return rnd.Next(from, to);
		}
	}

	internal class WObject
	{
		private Random rnd = new Random();

		public PointF Position;
		public int speed;
		private Point target;
		private PointF direction;
		private PointF step;
		public int count = 0;

		public int rad = 10;
		public Brush brush;

		private Control field;

		public bool DivideNeeded { get { return rad >= 20; } }

		public WObject(Control f, Brush b, PointF p, int spd)
		{
			field = f;
			brush = b;
			Position = p;
			speed = spd;//ServFunctions.GetNumber(1, 10);
			updateTarget(field.Width, field.Height);
		}

		private bool collided(PointF p1, PointF p2, int r1, int r2)
		{
			double x = p2.X - p1.X;
			double y = p2.Y - p1.Y;

			double g = Math.Sqrt(x * x + y * y);

			return g < (r1 + r2);
		}

		private PointF getDirection(PointF p0, PointF p1)
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

		private void updateTarget(int width, int height)
		{
			target = ServFunctions.GetRandomPoint(width, height);

			direction = getDirection(Position, target);

			step = new PointF
			{
				X = direction.X * speed,
				Y = direction.Y * speed
			};
		}

		public void Draw(Graphics gr)
		{
			float _xrad = rad + 5;
			float _yrad = rad;

			var p = new Pen(Brushes.Black, 1.0f);

			double angle = Math.Atan(direction.Y / direction.X) * (180.0 / Math.PI);

			//gr.TranslateTransform(Position.X - rad, Position.Y - rad);
			gr.TranslateTransform(Position.X, Position.Y);
			gr.RotateTransform(Convert.ToSingle(angle));
			gr.TranslateTransform(-_xrad, -_yrad);

			//gr.FillEllipse(brush, Position.X - rad, Position.Y - rad, rad * 2, rad * 2);
			gr.FillEllipse(brush, 0, 0, _xrad * 2, _yrad * 2);
			gr.DrawRectangle(p, 0, 0, _xrad * 2, _yrad * 2);
			//gr.DrawRectangle(p, Position.X - rad, Position.Y - rad, rad * 2, (rad - 5) * 2);

			gr.ResetTransform();

			// Center point
			gr.FillEllipse(Brushes.Black, Position.X - 2, Position.Y - 2, 4, 4);
			// Target
			gr.FillEllipse(brush, target.X - 5, target.Y - 5, 10, 10);

			var p1 = new Pen(Brushes.Black, 1.0f);
			gr.DrawLine(p1, Position, target);

			Font drawFont = new Font("Consolas", 8, FontStyle.Bold);
			SolidBrush drawBrush = new SolidBrush(Color.Black);

			string str = $">{rad}<";
			var s = gr.MeasureString(str, drawFont);

			gr.DrawString(str, drawFont, brush, Position.X - s.Width / 2, Position.Y - rad - drawFont.Height);
		}

		public void Move()
		{
			Position.X += step.X;
			Position.Y += step.Y;

			if (collided(Position, target, 4, 4))
			{
				updateTarget(field.Width, field.Height);
				count++;
				rad++;
			}
		}
	}
}