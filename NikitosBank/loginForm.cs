using System;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;

namespace NikitosBank
{
    public partial class LoginForm : Form
    {
        private readonly Database db = new Database();
        public LoginForm()
        {
            InitializeComponent();
            db.InitializeDatabase();
            // Всем привет меня зовут никита 1231
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(loginText.Text) && !string.IsNullOrEmpty(passwordText.Text))
            {
                string login = loginText.Text;
                string password = passwordText.Text;
                if(db.isValidLogin(login, password))
                {
                    CalculateIncome incomeForm = new CalculateIncome(login, password, db);
                    incomeForm.Show();
                    this.Close();
                }
            }
        }
        private void registerAccountButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(db);
            registerForm.Show();
            this.Close();
        }
    }
}
