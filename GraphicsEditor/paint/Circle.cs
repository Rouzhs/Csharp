using System;
using System.Drawing;
using System.Windows.Forms;

namespace paint
{
		public class Circle : Figure
		{
				public Circle()
				{

				}
				public Circle(Color colour, Point begin, Point end) : base(colour, begin, end)
				{

				}
				public override Bitmap Draw(Bitmap pic, int width)
				{
						Point center = PointBegin;
						Point radius = PointEnd;
						int diameter = Convert.ToInt32(2 * Math.Sqrt((radius.X - center.X) * (radius.X - center.X) +
								(radius.Y - center.Y) * (radius.Y - center.Y)));
						Pen pen = new Pen(Colour);
						pen.Width = width;
						Graphics gr = Graphics.FromImage(pic);
						gr.DrawEllipse(pen, center.X - diameter / 2, center.Y - diameter / 2, diameter, diameter);
						return pic;
				}

				public override bool isBelongs(MouseEventArgs e)
				{
						int R = Convert.ToInt32(Math.Sqrt((PointEnd.X - PointBegin.X) * (PointEnd.X - PointBegin.X) +
													(PointEnd.Y - PointBegin.Y) * (PointEnd.Y - PointBegin.Y)));//радиус окружности

						int distance = Convert.ToInt32(Math.Sqrt((e.X - PointBegin.X) * (e.X - PointBegin.X) +
						(e.Y - PointBegin.Y) * (e.Y - PointBegin.Y)));//расстояние от центра окружности до положения мыши

						return R == distance || R == distance + 1 || R == distance - 1;
				}

				public override void Change(int deltaX, int deltaY)
				{
						PointBegin = new Point(PointBegin.X + deltaX, PointBegin.Y + deltaY);
						PointEnd = new Point(PointEnd.X + deltaX, PointEnd.Y + deltaY);
				}
		}
}