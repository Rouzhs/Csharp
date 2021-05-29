using System;
using System.Windows.Forms;

namespace Studio
{
		public partial class ReferForm : Form
		{
				public Form1 activeForm;

				public ReferForm(Form1 mainForm)
				{
						activeForm = mainForm;
						InitializeComponent();
						Show();
				}

				private void buttonAdd_Click(object sender, EventArgs e)
				{
						activeForm.parameters.ReferencedAssemblies.Add(textBox1.Text);
						Close();
				}
		}
}
