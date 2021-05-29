using System;
using System.Drawing;
using System.Windows.Forms;

namespace paint
{
		public class Straight : Figure
		{
				public Straight()
				{

				}
				public Straight(Color colour, Point begin, Point end) : base(colour, begin, end)
				{

				}
				public override Bitmap Draw(Bitmap pic, int width)
				{
						Pen pen = new Pen(Colour);
						pen.Width = width;
						Graphics gr = Graphics.FromImage(pic); 
						gr.DrawLine(pen, PointBegin, PointEnd);

						return pic;
				}

				public override bool isBelongs(MouseEventArgs e)
				{
						int dist1 = Convert.ToInt32(Math.Sqrt((e.X - PointBegin.X) * (e.X - PointBegin.X) +
												(e.Y - PointBegin.Y) * (e.Y - PointBegin.Y)));

						int dist2 = Convert.ToInt32(Math.Sqrt((e.X - PointEnd.X) * (e.X - PointEnd.X) +
						(e.Y - PointEnd.Y) * (e.Y - PointEnd.Y)));

						int distSum12 = Convert.ToInt32(Math.Sqrt((PointEnd.X - PointBegin.X) * (PointEnd.X - PointBegin.X) +
						(PointEnd.Y - PointBegin.Y) * (PointEnd.Y - PointBegin.Y)));

						return (dist1 + dist2 == distSum12 || dist1 + dist2 == distSum12 + 1 ||
								dist1 + dist2 == distSum12 - 1 || dist1 + dist2 == distSum12 + 2);
				}

				public override void Change(int deltaX, int deltaY)
				{
						PointBegin = new Point(PointBegin.X + deltaX, PointBegin.Y + deltaY);
						PointEnd = new Point(PointEnd.X + deltaX, PointEnd.Y + deltaY);
				}
		}
}