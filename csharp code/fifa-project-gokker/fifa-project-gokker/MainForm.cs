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

        private void MainForm_Load(object sender, EventArgs e)
        {
            loadTeams();
            loadTypes();
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

        public void loadTypes()
        {
            string[] types = new string[2];
            types[0] = "Double or Nothing";
            types[1] = "Tripple or Nothing";

            typeBetComboBox.Items.Add(types[0]);
            typeBetComboBox.Items.Add(types[1]);
        }

        private void typeBetComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typeBetComboBox.SelectedItem.ToString() == "Double or Nothing")
            {
                endScoreTeam1Numeric.Enabled = false;
                endScoreTeam2Numeric.Enabled = false;
            }
            if (typeBetComboBox.SelectedItem.ToString() == "Tripple or Nothing")
            {
                endScoreTeam1Numeric.Enabled = true;
                endScoreTeam2Numeric.Enabled = true;
            }
        }

        private void makeBetButton_Click(object sender, EventArgs e)
        {
            if (typeBetComboBox.SelectedItem == null)
            {
                MessageBox.Show("Vul een weddenschap type in");
            }

            if (typeBetComboBox.SelectedItem != null && 
                amountNumeric.Value == 0 && 
                typeBetComboBox.SelectedItem.ToString() == "Double or Nothing")
            {
                MessageBox.Show("Vul een inzet in van minimaal 5");
            }

            if (typeBetComboBox.SelectedItem != null && 
                amountNumeric.Value == 0 && 
                typeBetComboBox.SelectedItem.ToString() == "Tripple or Nothing")
            {
                MessageBox.Show("Vul een inzet in van minimaal 15");
            }

            if (typeBetComboBox.SelectedItem != null && 
                winningTeamComboBox.SelectedItem == null)
            {
                MessageBox.Show("Vul het winnende team in");
            }

            if (typeBetComboBox.SelectedItem != null &&
                typeBetComboBox.SelectedItem.ToString() == "Tripple or Nothing")
            {
                MessageBox.Show("Vul de eindscore in");
            }
        }

        private void loginToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();

            if (Program.isLoggedIn)
            {
                makeBetGroupBox.Enabled = true;
            }
        }
    }
}
