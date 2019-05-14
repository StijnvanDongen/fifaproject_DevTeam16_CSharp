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
        const string LOGINAPI_URL = "http://mennovermeulen.ga/api/loginapi.php";
        const string WEDSTRIJDENAPI_URL = "http://mennovermeulen.ga/api/wedstrijdenapi.php";

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
            loadUsers();
            loadWedstrijden();
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
                    Program.teamList.Add(team);
                } 

                for ( int i = 0; i < Program.teamList.Count; i++)
                {
                    teamsListBox.Items.Add(Program.teamList[i].teamName);
                }

            }
            catch (System.Net.WebException)
            {
                MessageBox.Show("Je hebt geen internet verbinding!");
            }
            catch (System.ArgumentNullException)
            {
                MessageBox.Show("Er is geen api_url opgegeven");
            }
            catch (System.ArgumentException)
            {
                MessageBox.Show("Het pad heeft een ongeldige indeling. er moet een andere api link ingevuld worden");
            }
            catch (Newtonsoft.Json.JsonReaderException)
            {
                MessageBox.Show("Unexpected character encountered, er is een foute api link aangegeven");
            }
        }



        public void loadUsers()
        {
            try
            {
                WebClient webClient = new WebClient();
                string userjson = webClient.DownloadString(LOGINAPI_URL);

                dataUsers[] users = JsonConvert.DeserializeObject<dataUsers[]>(userjson);

                foreach (dataUsers user in users)
                {
                    Program.userslist.Add(user);
                }

            }
            catch (System.Net.WebException)
            {
                MessageBox.Show("Je hebt geen internet verbinding!");
            }
        }



        public void loadWedstrijden()
        {
            try
            {
                WebClient webClient = new WebClient();
                string wedstrijdenjson = webClient.DownloadString(WEDSTRIJDENAPI_URL);

                dataWedstrijden[] wedstrijden = JsonConvert.DeserializeObject<dataWedstrijden[]>(wedstrijdenjson);

                foreach (dataWedstrijden wedstrijd in wedstrijden)
                {
                    Program.wedstrijdlist.Add(wedstrijd);
                }

                for ( int i = 0; i < Program.wedstrijdlist.Count; i++ )
                {
                    string wedstrijd = String.Format("{0} - {1}", Program.wedstrijdlist[i].team1, Program.wedstrijdlist[i].team2);
                    tournamentsListBox.Items.Add(wedstrijd);
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
