using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fifa_project_gokker
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text == "")
            {
                MessageBox.Show("Vul een Gebruikersnaam");
            }
            if (passwordTextBox.Text == "")
            {
                MessageBox.Show("Vul een E-mailadres in");
            }
            if (userNameTextBox.Text != "" && passwordTextBox.Text != "")
            {


                Program.isLoggedIn = true;
                this.Close();
            }
        }
    }
}
