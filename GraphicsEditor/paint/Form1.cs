using System;
using System.Drawing;
using System.Windows.Forms;

namespace paint
{
		public partial class Form1 : Form
		{
				public Figure[] figures;
				public Bitmap pic; //основной холст
    public Bitmap pic2;//холст для дополнительных промежуточных действий: отрисовка фигуры в процессе удерживания нажатой лкм
				public int cntFigures;//количество фигур (нумерация фигур с единицы)
				public bool isChange;//выбрана ли для редактирования какая-либо фигура
				public Figure chFig;//выбранная для редактирования фигура

			
				public Form1()
				{
						cntFigures = 0;
						isChange = false;
						chFig = null;
						figures = new Figure[100];
						pic = new Bitmap(1080, 720);
						pic2 = null;

						InitializeComponent();
				}

				public Bitmap DrawAllElementsInPicture()
				{
						Bitmap newpic = new Bitmap(pic.Width, pic.Height);
				
						for (int i = 1; i <= cntFigures; i++)
						{
								newpic = (Bitmap)figures[i].Draw(newpic,1).Clone();
						}
      pictureBox.Image = newpic;
						pic = (Bitmap)newpic.Clone();
						return newpic;
				}
				
				public void pictureBox_MouseMove(object sender, MouseEventArgs e)
				{
						if (e.Button == MouseButtons.Left)
						{
								if (isChange)//если до этого перемещался/изменялся объект, 
								{            //отрисовать все объекты на текущих позициях и записать в pic
										isChange = false;
										Bitmap newpic = DrawAllElementsInPicture();
										pic = (Bitmap)newpic.Clone();
										pictureBox.Image = pic;
								}
        
								//ввод новых примитивов:
								pic2 = (Bitmap)pic.Clone();
								figures[cntFigures].ChangeWhilePainting(e);
								pic2 = (Bitmap)figures[cntFigures].Draw(pic2, 1).Clone();
								pictureBox.Image = pic2;
						}
						else if (e.Button == MouseButtons.Right)//выделение примитива для редактирования
						{
								for (int i = 1; i <= cntFigures; i++)
								{
										Figure fig = figures[i];
										Bitmap pic3 = null;
										
										//Проверки на принадлежность текущей точки какой-либо линии
										if (fig.isBelongs(e))
										{
											 pic3 = (Bitmap)GetPicWithoutSelectedFigure(i).Clone();//взять pic без fig
												pic = (Bitmap)pic3.Clone();//рисунок, включающий все примитивы кроме выбранного
												pic3 = (Bitmap)fig.Draw(pic3, 5).Clone();//рисуем не на основной холст т.к. это промежуточное состояние общего рисунка
												
												pictureBox.Image = pic3;
												panelCurrentColor.BackColor = fig.Colour;//установка параметров примитива в элементы управления
												hScrollBar.Value = fig.PointBegin.X;
												vScrollBar.Value = fig.PointBegin.Y;
												isChange = true;
												chFig = fig;
												break;
										}
								}
						}
				}

				public Bitmap GetPicWithoutSelectedFigure(int indexSelectedFigure)
				{
						Bitmap newpic = new Bitmap(pic.Width, pic.Height);
						for (int i = 1; i <= cntFigures; i++)
						{
								if (i != indexSelectedFigure)
								 	newpic = (Bitmap)figures[i].Draw(newpic, 1).Clone();
						}
						return newpic;
				}

				public void pictureBox_MouseDown(object sender, MouseEventArgs e)
				{
						if (e.Button == MouseButtons.Left)
						{
								cntFigures++;
								if (labelFigure.Text == "Curve")
								{
										figures[cntFigures] = new Curve(panelSelectedColor.BackColor, e.Location, e.Location);
								}
								else if (labelFigure.Text == "Straight")
								{
										figures[cntFigures] = new Straight(panelSelectedColor.BackColor, e.Location, e.Location);
								}
								else if (labelFigure.Text == "Circle")
								{
										figures[cntFigures] = new Circle(panelSelectedColor.BackColor, e.Location, e.Location);
								}
								else if (labelFigure.Text == "Rectangle")
								{
										figures[cntFigures] = new Rectangle(panelSelectedColor.BackColor, e.Location, e.Location);
								}
						}
				}

				public void pictureBox_MouseUp(object sender, MouseEventArgs e)
				{
						if (e.Button == MouseButtons.Left)
						{
								pic = (Bitmap)pic2.Clone();
						}
				}

				public void ScrollBar_Scroll(object sender, ScrollEventArgs e)
				{
						if (isChange)
						{
								int deltaX = hScrollBar.Value - chFig.PointBegin.X;
								int deltaY = vScrollBar.Value - chFig.PointBegin.Y;
								if (sender.GetType() == hScrollBar.GetType())
								{
										deltaX = e.NewValue - chFig.PointBegin.X;
								}
								else //vScrollBar
								{
										deltaY = e.NewValue - chFig.PointBegin.Y;
								}
																
								chFig.Change(deltaX, deltaY);
								pic2 = (Bitmap)pic.Clone();
								pic2 = (Bitmap)chFig.Draw(pic2, 5).Clone();
								pictureBox.Image = pic2;
						}
				}
				
				private void buttonSomeFigure_Click(object sender, EventArgs e)
				{
						labelFigure.Text = ((Button)sender).Text;
				}

				private void buttonChangeCurrentColor_Click(object sender, EventArgs e)
				{
						ColorDialog colorDialog = new ColorDialog();
						if (colorDialog.ShowDialog() == DialogResult.OK)
						{
								panelCurrentColor.BackColor = colorDialog.Color;
								chFig.Colour = colorDialog.Color;
								pic = (Bitmap)DrawAllElementsInPicture().Clone();
								pictureBox.Image = pic;
						}
				}

				private void buttonChangeSelectedColor_Click(object sender, EventArgs e)
				{
						ColorDialog colorDialog = new ColorDialog();
						if(colorDialog.ShowDialog() == DialogResult.OK)
						{
								panelSelectedColor.BackColor = colorDialog.Color;
						}
				}
		}
}
