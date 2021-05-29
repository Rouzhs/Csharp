using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace container
{
		public partial class Form1 : Form
		{
				public Form1()
				{
						InitializeComponent();
				}

				private string specString = "[specialsymbol]";

				private void buttonOpenContainer_Click(object sender, EventArgs e)
				{
						dataGridView.Rows.Clear();
						OpenFileDialog openContainer = new OpenFileDialog();
						if (openContainer.ShowDialog() != DialogResult.OK)
								return;

						FileInfo fileInfo = new FileInfo(openContainer.FileName);
						if (fileInfo.Extension != ".cntr")
						{
								labelOpenedContainer.Text = "It is not container with extension .cntr";
								return;
						}
						labelOpenedContainer.Text = openContainer.FileName;

						using (var cont = new FileStream(labelOpenedContainer.Text, FileMode.Open, FileAccess.Read))
						{
								byte[] data = new byte[cont.Length];
								cont.Read(data, 0, data.Length);
								string str = Encoding.Default.GetString(data);
								var position = str.LastIndexOf(specString);
								string info = str.Substring(position + specString.Length);
								string[] infoMassive = info.Split(' ');

								dataGridView.Rows.Clear();
								for (int i = 0; i < infoMassive.Length - 1; i += 3)
								{
										try
										{
												dataGridView.Rows.Add(infoMassive[i], infoMassive[i + 1]);
										}
										catch
										{
												labelOpenedContainer.Text = "The file is damaged";//вышел за границы, что невозможно при корректной работе с контейнером
												return;
										}
								}
						}
				}

				private void buttonCreateContainer_Click(object sender, EventArgs e)
				{
						OpenFileDialog dialog = new OpenFileDialog();
						if (dialog.ShowDialog() != DialogResult.OK)
								return;
						string fileName = dialog.FileName;

						var finfo = new FileInfo(fileName);
						var folder = new FolderBrowserDialog();
						if (folder.ShowDialog() != DialogResult.OK)
								return;

						string dir = folder.SelectedPath;
						string newContainerName = textBoxNewContainerName.Text + ".cntr";

						using (var cont = new FileStream(dir + "\\" + newContainerName, FileMode.Create))
						{
								using (var file = new FileStream(fileName, FileMode.Open))
								{
										var fileCode = new byte[file.Length];
										file.Read(fileCode, 0, fileCode.Length);
										cont.Write(fileCode, 0, fileCode.Length); //код файла
										string fileInfoStr = specString + finfo.Name + " " + Convert.ToString(fileCode.Length) + " 0 ";
										cont.Write(Encoding.Default.GetBytes(fileInfoStr), 0, fileInfoStr.Length);
										//спец. символ и информация о файле: имя, размер, отступ										
								}
						}
				}

				private void buttonAddFile_Click(object sender, EventArgs e)
				{
						var dialog = new OpenFileDialog();
						if (dialog.ShowDialog() != DialogResult.OK)
								return;
						string fileName = dialog.FileName;

						using (var f = new FileStream(fileName, FileMode.Open))
						{
								using (var cont = new FileStream(labelOpenedContainer.Text, FileMode.Open, FileAccess.ReadWrite))
								{
										byte[] data = new byte[cont.Length];
										cont.Read(data, 0, data.Length);
										string str = Encoding.Default.GetString(data);
										var position = str.LastIndexOf(specString);
										string info = str.Substring(position + specString.Length);

										byte[] masbyte = new byte[f.Length];
										f.Read(masbyte, 0, Convert.ToInt32(f.Length));

										FileInfo fileInfo = new FileInfo(fileName);
										string newFileData = fileInfo.Name + " " + Convert.ToString(masbyte.Length) + " " + Convert.ToString(position) + " ";

										cont.Position = 0;//перезаписываем с начала весь файл-контейнер

										cont.Write(data, 0, position);//[0;position) - код файлов без дополнительной информации
										cont.Write(masbyte, 0, masbyte.Length);//код нового файла
										cont.Write(Encoding.Default.GetBytes(specString), 0, specString.Length);//спец символ
										cont.Write(Encoding.Default.GetBytes(info), 0, info.Length);//информация о старых файлах
										cont.Write(Encoding.Default.GetBytes(newFileData), 0, newFileData.Length);//информация о новом файле		

										dataGridView.Rows.Add(fileInfo.Name, Convert.ToString(masbyte.Length));
								}
						}
				}

				private void buttonExtract_Click(object sender, EventArgs e)
				{
						int indexSelectedRow = dataGridView.SelectedCells[0].RowIndex;//какой по счету файл в списке (нумерация с нуля)
						using (var cont = new FileStream(labelOpenedContainer.Text, FileMode.Open))
						{
								var data = new byte[cont.Length];//весь контейнер
								cont.Read(data, 0, data.Length);
								string str = Encoding.Default.GetString(data);//весь контейнер в виде строки
								var position = str.LastIndexOf(specString);
								string info = str.Substring(position + specString.Length);//список информации о файлах
								string[] infoMassive = info.Split(' ');//список информации о файлах в виде массива

								string name = infoMassive[(indexSelectedRow * 3)];
								int size = Convert.ToInt32(infoMassive[(indexSelectedRow * 3 + 1)]);
								int offset = Convert.ToInt32(infoMassive[(indexSelectedRow * 3 + 2)]);

								var folder = new FolderBrowserDialog();
								if (folder.ShowDialog() != DialogResult.OK)
										return;

								string fileData = str.Substring(offset, size);
								using (var f = new FileStream(folder.SelectedPath + "\\" + name, FileMode.Create))
								{
										f.Write(Encoding.Default.GetBytes(fileData), 0, fileData.Length);
								}
						}
				}
		}
}