using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NikitosBank
{
    partial class RegisterForm : Form
    {
        Database db;
        public RegisterForm(Database database)
        {
            InitializeComponent();
            this.db = database;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(loginUserText.Text) && !string.IsNullOrEmpty(passwordUserText.Text) && !string.IsNullOrEmpty(fullUserNameText.Text))
            {
                string login = loginUserText.Text;
                string password = passwordUserText.Text;
                string fullName = fullUserNameText.Text;
                db.AddNewUser(login, password, fullName);
                this.Close();
            }
        }
    }
}
