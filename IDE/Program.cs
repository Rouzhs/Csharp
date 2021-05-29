using System;
using System.Windows.Forms;

namespace Studio
{
		static class Program
		{
				[STAThread]
				static void Main()
				{
						Application.EnableVisualStyles();
						Application.SetCompatibleTextRenderingDefault(false);
						IGoodbye form = new Form1();
						form.Goodbye();
				}
		}

		public interface IGoodbye
		{
				void Goodbye();
		}
}