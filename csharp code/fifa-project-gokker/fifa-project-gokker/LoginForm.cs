using CryptSharp;
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
            passwordTextBox.PasswordChar = '*';
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text == "")
            {
                MessageBox.Show("Vul een Gebruikersnaam");
            }
            if (passwordTextBox.Text == "")
            {
                MessageBox.Show("Vul een Wachtwoord in");
            }
            if (userNameTextBox.Text != "" && passwordTextBox.Text != "")
            {
                for ( int i = 0; i < Program.userslist.Count; i++)
                {
                    if ( Program.userslist[i].userName == userNameTextBox.Text )
                    {
                        if ( Crypter.CheckPassword( passwordTextBox.Text, Program.userslist[i].password ) )
                        {
                            Program.isLoggedIn = true;
                        }
                        else
                        {
                        }
                    }
                    else
                    {
                    }
                }
                if ( Program.isLoggedIn == false )
                {
                    userNameTextBox.Text = "";
                    passwordTextBox.Text = "";
                    MessageBox.Show("Gebruikersnaam of wachtwoord is ongeldig");
                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}
