using paint;
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace serialization
{
		public class Elements
		{
				public Figure[] figs { get; set; }
				public int[] colors { get; set; }  //для возможности сериализовать цвет

				public Elements()
				{
						
				}
				public Elements(Figure[] figures)
				{
						figs = new Figure[100];
						colors = new int[100];
						for (int i = 1; i < 100; i++)
						{
								if (figures[i] == null) break;

								figs[i] = figures[i];
								colors[i] = figures[i].Colour.ToArgb();
						}
				}
		}

		public partial class FormSaveImage : Form
		{
				public Figure[] figures;
				public FormSaveImage(Figure[] figures)
				{
						this.figures = figures;
						InitializeComponent();
				}
			
				private void buttonOKsaveImage_Click(object sender, EventArgs e)
				{
						FolderBrowserDialog fbd = new FolderBrowserDialog();
						if (fbd.ShowDialog() != DialogResult.OK)
								return;
						string filePath = fbd.SelectedPath;

						Type[] types =
						{
								typeof(Curve),
								typeof(Straight),
								typeof(Circle),
								typeof(Rectangle)
						};

						XmlSerializer xml = new XmlSerializer(typeof(Elements), types);
						Elements elem = new Elements(figures);
						
						using (FileStream f = new FileStream(filePath + "\\" + textBox1.Text + ".serial", FileMode.Create))
						{
								xml.Serialize(f, elem);
						}
						this.Close();
				}
		}
}