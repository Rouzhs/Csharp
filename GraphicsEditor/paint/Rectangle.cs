using System;
using System.Drawing;
using System.Windows.Forms;

namespace paint
{
		public class Rectangle : Figure
		{
				public Rectangle()
				{

				}
				public Rectangle(Color colour, Point begin, Point end) : base(colour, begin, end)
				{

				}
				public override Bitmap Draw(Bitmap pic, int width)
				{
						Pen pen = new Pen(Colour);
						pen.Width = width;
						Graphics gr = Graphics.FromImage(pic);
						gr.DrawRectangle(pen, PointBegin.X, PointBegin.Y, PointEnd.X - PointBegin.X, PointEnd.Y - PointBegin.Y);
						return pic;
				}

				public override bool isBelongs(MouseEventArgs e)
				{
						return PointBegin.X == e.X && PointBegin.Y <= e.Y && PointEnd.Y >= e.Y ||
														PointBegin.Y == e.Y && PointBegin.X <= e.X && PointEnd.X >= e.X;
				}

				public override void Change(int deltaX, int deltaY)
				{
						PointBegin = new Point(PointBegin.X + deltaX, PointBegin.Y + deltaY);
						PointEnd = new Point(PointEnd.X + deltaX, PointEnd.Y + deltaY);
				}
		}
}