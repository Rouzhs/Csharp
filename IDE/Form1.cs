using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Microsoft.CSharp;

namespace Studio
{
		public delegate void ProcessMethod(object obj, EventArgs ev);

		public partial class Form1 : Form, IGoodbye
		{
				public Process process;//запущенное в этой студии приложение 
				public string OpenedFile;
				public event ProcessMethod ProcessDied;
				public CompilerParameters parameters;
				public static Timer timer;

				public Form1()
				{
						string[] dll = { "System.dll", "mscorlib.dll", "System.Core.dll" };//основные сборки, остальные можно подгружать в процессе
						parameters = new CompilerParameters(dll, "proga.exe", true);
						parameters.GenerateExecutable = true;  //создать исполняемый файл
						process = null;
						OpenedFile = "";
						InitializeComponent();

						//способы сменить кнопки:
						//1
						ProcessDied += SwapButtons;  //делегат и подписка на событие
						
						//2
						ProcessDied += (s, a) => { SwapButtons(s, a); };//делегат (для создания события) и лямбда выражение

						//3
						foreach (Control tool in Controls)//событие движения мыши и лямбда выражение
						{
								tool.MouseMove += (s, a) => { if (process != null && process.HasExited == true) SwapButtons(s, a); };
						}
						MouseMove += (s, a) => { if (process != null && process.HasExited == true) SwapButtons(s, a); };

						//4
						timer = new Timer();//таймер и лямбда выражение
						timer.Interval = 100;
						timer.Tick += (s, a) => { if (process != null && process.HasExited == true) SwapButtons(s, a); };
						timer.Start();

						Application.Run(this);
				}


				public void Start_Click(object sender, EventArgs e)
				{
						CSharpCodeProvider provider = new CSharpCodeProvider();
						CompilerResults results = provider.CompileAssemblyFromSource(parameters, textBoxCode.Text); //Компилирует сборку из указанного массива строк 
						if (results.Errors.HasErrors)
						{
								textBoxErrors.Text = "";
								foreach (var error in results.Errors.Cast<CompilerError>())
								{
										textBoxErrors.Text += $"Line {error.Line}:  {error.ErrorText}\n";
								}
						}
						else
						{
								textBoxErrors.Text = "OK";
								string progname = "proga.exe";
								process = Process.Start($"{Application.StartupPath}/{ progname }");  //нахождение пути к .exe
								toolStripButtonStart.Visible = false;
								toolStripButtonStop.Visible = true;
						}
				}
				

				public void SaveNewFile_Click(object sender, EventArgs e)
				{
						new SaveForm(textBoxCode.Text);
				}


				public void Open_Click(object sender, EventArgs e)
				{
						OpenFileDialog ofd = new OpenFileDialog();
						if (ofd.ShowDialog() != DialogResult.OK)
								return;

						using (var f = new FileStream(ofd.FileName, FileMode.Open))
						{
								var fileCode = new byte[f.Length];
								f.Read(fileCode, 0, fileCode.Length);
								textBoxCode.Text = Encoding.Default.GetString(fileCode);
						}
						toolStripButtonSave.Visible = true;
						OpenedFile = ofd.FileName;
				}


				public void SaveOpenedFile_Click(object sender, EventArgs e)
				{
						using (var f = new FileStream(OpenedFile, FileMode.Create))
						{
								f.Write(Encoding.Default.GetBytes(textBoxCode.Text), 0, textBoxCode.Text.Length);
						}
				}


				private void pasteTheBaseCode_Click(object sender, EventArgs e)
				{
						textBoxCode.Text = "using System;\n\nnamespace space\n{\n   static class Program\n   {\n" +
								"      static void Main()\n      {\n         Console.ReadKey();\n      }\n   }\n}";
				}


				private void assembliesToolStripMenuItem_Click(object sender, EventArgs e) => new ReferForm(this);


				public void Goodbye()
				{
						MessageBox.Show("Have a nice day!");
				}



				//смена кнопок:

				public void SwapButtons(object sender, EventArgs e)
				{
						toolStripButtonStart.Visible = true;
						toolStripButtonStop.Visible = false;
				}


				public void Stop_Click(object sender, EventArgs e)
				{
						process.Kill();
						ProcessDied(this, e);
				}

				
				public void formMouseMove(object sender, MouseEventArgs e)
				{
						if (process != null && process.HasExited == true)
						{
								ProcessDied(this, EventArgs.Empty);
						}
				}
		}
}