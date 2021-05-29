using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Studio
{
		public partial class SaveForm : Form
		{
				string Code;
				public SaveForm(string code)
				{
						Code = code;
						InitializeComponent();
						Show();
				}

				private void buttonOK_Click(object sender, EventArgs e)
				{
						var fbd = new FolderBrowserDialog();
						if (fbd.ShowDialog() != DialogResult.OK)
						{
								Close();
								return;
						}
								
						using (var f = new FileStream(fbd.SelectedPath + "\\" + textBoxName.Text + ".cs", FileMode.Create))
						{
								f.Write(Encoding.Default.GetBytes(Code), 0, Code.Length);
						}
						Close();
				}

				private void buttonCancel_Click(object sender, EventArgs e)
				{
						Close();
				}
		}
}
