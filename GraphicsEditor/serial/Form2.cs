using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using paint;

namespace serialization
{
		public partial class Form2 : Form1
		{
				public Form2():base()
				{
							InitializeComponent();
				}

				public void saveToolStripMenuItem_Click(object sender, EventArgs e)
				{
						FormSaveImage formSave = new FormSaveImage(figures);
						formSave.ShowDialog();
				}

				private void openToolStripMenuItem_Click(object sender, EventArgs e)
				{
						OpenFileDialog ofd = new OpenFileDialog();
						if(ofd.ShowDialog() == DialogResult.OK)
						{
								Type[] types =
								{
										typeof(Curve),
										typeof(Straight),
										typeof(Circle),
										typeof(paint.Rectangle)
								};

								XmlSerializer xml = new XmlSerializer(typeof(Elements), types);
								
								Elements serializedFigures;
								using (FileStream f = new FileStream(ofd.FileName, FileMode.Open))
								{
										serializedFigures = (Elements)xml.Deserialize(f);
								}
								figures = serializedFigures.figs;
								
								for (int i = 1; i < figures.Length; i++)
								{
										if(figures[i] == null)
										{
												cntFigures = i - 1;
												break;
										}
										else
										{
												figures[i].Colour = Color.FromArgb(serializedFigures.colors[i]);
										}
								}
							 pic = (Bitmap)DrawAllElementsInPicture().Clone();
								pictureBox.Image = pic;
						}
				}
		}
}
