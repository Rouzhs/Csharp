using KURSACH;
using System;
using System.Windows.Forms;

namespace KURS
{
    public partial class EnterForm : Form
    {
        private DataBase db;
        public EnterForm()
        {
            InitializeComponent();
            db = new DataBase();            
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (WrongDataFormat())
            {
                return;
            }

            var user = new User(textBoxLogin.Text, textBoxPassword.Text, textBoxRole.Text);

             var adapter = db.Request($"SELECT * FROM users WHERE login = '{user.Login}' " +
                $"AND password = '{user.Password}' AND role = '{user.Role}'; ");

            if (!db.isEmptyAnswer(adapter))
            {
                //this.Hide();
                if (user.Role == "student")
                {
                    UserForm userform = new UserForm(user);
                    userform.Show();
                }
                else if (user.Role == "author")
                {
                    AuthorForm authorform = new AuthorForm(user);
                    authorform.Show();
                }
            }
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            if (WrongDataFormat())
            {
                return;
            }

            var user = new User(textBoxLogin.Text, textBoxPassword.Text, textBoxRole.Text);

            db.Insert("INSERT INTO users (login, password, role) " +
                $"VALUES('{user.Login}', '{user.Password}', '{user.Role}');");
        }


        private bool WrongDataFormat()
        {
            return (textBoxLogin.Text == "" || textBoxPassword.Text == "" || textBoxRole.Text == ""
                || !(textBoxRole.Text == "student" || textBoxRole.Text == "author"));
        }
    }
}
