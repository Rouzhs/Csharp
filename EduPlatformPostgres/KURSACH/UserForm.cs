using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace KURSACH
{
    public partial class UserForm : Form
    {
        User user;
        DataBase db;
        int tmpTaskID;
        public UserForm(User user)
        {
            InitializeComponent();
            this.user = user;
            db = new DataBase();
            db.ConnectBD();
            this.Text = user.Login + ", " + user.Role;
            Form1_Load(this, EventArgs.Empty);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ChooseTask_Click(object sender, EventArgs e)
        {
            var adapter = db.Request("SELECT id, problem FROM tasks");
            var dt = db.GetData(adapter);
            dataGrid.DataSource = dt;
            dataGrid.AutoResizeRows();
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.RowIndex >= 0)
            {
                var adapter = db.Request($"SELECT problem FROM tasks WHERE id = '{e.RowIndex + 1}';");
                var dt = db.GetData(adapter);
                textBoxProblem.Text = dt.Rows[0][0].ToString();
                tmpTaskID = e.RowIndex + 1;
            }
        }

        private void buttonRunCode_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("input.txt", false))
            {
                var adapter = db.Request($"SELECT input FROM tasks WHERE id = '{tmpTaskID}';");
                var dt = db.GetData(adapter);
                sw.WriteLine(dt.Rows[0][0].ToString());
            }
            using (StreamWriter sw = new StreamWriter("output.txt", false))
            {
                sw.WriteLine("");
            }
            string[] dll = { "System.dll", "mscorlib.dll", "System.Core.dll" };
            var parameters = new CompilerParameters(dll, "proga.exe", true);
            parameters.GenerateExecutable = true;
            var provider = new CSharpCodeProvider();
            CompilerResults results = provider.CompileAssemblyFromSource(parameters,
                textBoxDecision.Text);
            if (results.Errors.HasErrors)
            {
                textBoxResult.Text = "";
                foreach (var error in results.Errors.Cast<CompilerError>())
                {
                    textBoxResult.Text += $"Line {error.Line}: {error.ErrorText}\n";
                }
            }
            else
            {
                textBoxResult.Text = "Compile status: OK";
                string progname = "proga.exe";
                var pr = Process.Start($"{Application.StartupPath}/{progname}");
                pr.WaitForExit();
            }
            string verdict;
            using (StreamReader sr = new StreamReader("output.txt"))
            {
                var adapter = db.Request($"SELECT output FROM tasks WHERE id = '{tmpTaskID}';");
                var dt = db.GetData(adapter);
                string studentAnswer = sr.ReadLine();
                string authorAnswer = dt.Rows[0][0].ToString();
                if (authorAnswer == studentAnswer)
                {
                    textBoxResult.Text += "\nYES";
                    verdict = "YES";
                }
                else
                {
                    textBoxResult.Text += "\nNO";
                    verdict = "NO";
                }
            }
            db.Insert("INSERT INTO attempts (id_student, id_task, code, verdict) " +
                            $"VALUES('{user.Login}', '{tmpTaskID}', '{textBoxDecision.Text}', " +
                            $"'{verdict}');");
        }
    }
}
