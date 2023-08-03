using KURSACH;
using System;
using System.Windows.Forms;

namespace KURS
{
    public partial class AuthorForm : Form
    {
        User user;
        DataBase db;
        public AuthorForm(User user)
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

        private void AddTask_Click(object sender, EventArgs e)
        {
            if (WrongDataFormat())
            {
                return;
            }
            var task = new KURSACH.Task(user.Login,textBoxProblem.Text,
                textBoxInput.Text,textBoxOutput.Text,textBoxDecision.Text );

            db.Insert("INSERT INTO tasks (creator, problem, input, output,decision) " +
                $"VALUES('{task.Creator}', '{task.Problem}', '{task.Input}', " +
                $"'{task.Output}', '{task.Decision}');");
        }

        private bool WrongDataFormat()
        {
            return (textBoxProblem.Text == "" || textBoxInput.Text == "" || 
                textBoxOutput.Text == "" || textBoxDecision.Text == "");
        }      
    }
}
