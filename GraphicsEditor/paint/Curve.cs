using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace paint
{
		public class Curve : Figure
		{
				public List<Point> track = new List<Point>();

				public Curve()
				{

				}
				public Curve(Color colour, Point begin, Point end) : base(colour, begin, end)
				{

				}
				public override Bitmap Draw(Bitmap pic, int width)
				{
						Pen pen = new Pen(Colour);
						pen.Width = width;
						Graphics gr = Graphics.FromImage(pic);
						for (int j = 0; j < track.Count - 1; j++)
						{
								gr.DrawLine(pen, track[j], track[j + 1]);
						}
						return pic;
				}
				public override bool isBelongs(MouseEventArgs e)
				{
						bool belongs = false;
						foreach (var p in track)
						{
								if (p == e.Location)
								{
										belongs = true;
										break;
								}
						}
						return belongs;
				}

				public override void Change(int deltaX, int deltaY)
				{
						PointBegin = new Point(PointBegin.X + deltaX, PointBegin.Y + deltaY);
						PointEnd = new Point(PointEnd.X + deltaX, PointEnd.Y + deltaY);
						for (int i = 0; i < track.Count; i++)
						{
								track[i] = new Point(track[i].X + deltaX, track[i].Y + deltaY);
						}
				}

				public override void ChangeWhilePainting(MouseEventArgs e)
				{
						track.Add(e.Location);
				}
		}
}