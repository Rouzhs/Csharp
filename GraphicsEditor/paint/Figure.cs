using System;
using System.Drawing;
using System.Windows.Forms;

namespace paint
{
		public abstract class Figure
		{
				public Color Colour { get; set; } 
				public Point PointBegin { get; set; }
				public Point PointEnd { get; set; }

				protected Figure()
				{

				}
				protected Figure(Color colour, Point begin, Point end)
			 {
						Colour = colour;
						PointBegin = begin;
						PointEnd = end;
						
				}

				public virtual Bitmap Draw(Bitmap pic, int width)
				{
						return pic;
				}

				public virtual bool isBelongs(MouseEventArgs e)
				{
						return true;
				}

				public virtual void Change(int deltaX, int deltaY)
				{
						
				}
				public virtual void ChangeWhilePainting(MouseEventArgs e)
				{
						PointEnd = e.Location;
				}

		}
}