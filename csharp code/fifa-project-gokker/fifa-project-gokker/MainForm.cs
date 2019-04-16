using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fifa_project_gokker
{
    public partial class MainForm : Form
    {
        const string API_URL = "http://mennovermeulen.ga/api/apihandler.php";

        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();

            makeBetGroupBox.Enabled = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            loadTeams();
        }

        public void loadTeams()
        {
            try
            {
                WebClient client = new WebClient();
                string json = client.DownloadString(API_URL);

                data[] teams = JsonConvert.DeserializeObject<data[]>(json);

                foreach (data team in teams)
                {
                    teamsListBox.Items.Add(team.teamName);
                }
            }
            catch (System.Net.WebException)
            {
                MessageBox.Show("Je hebt geen internet verbinding!");
            }
        }

        private void reloadTeamListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            teamsListBox.Items.Clear();
            loadTeams();
        }
    }
}
