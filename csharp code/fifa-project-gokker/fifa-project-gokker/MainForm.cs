using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fifa_project_gokker
{
    public partial class MainForm : Form
    {
        const string API_URL = "http://mennovermeulen.ga/api/apihandler.php?key=RBUUo3AZDy";
        const string LOGINAPI_URL = "http://mennovermeulen.ga/api/loginapi.php?key=dguaetj9lD";
        const string WEDSTRIJDENAPI_URL = "http://mennovermeulen.ga/api/wedstrijdenapi.php?key=Yl1EkejMXd";
        public string gokkerName = "";
        public string JSON = "";

        decimal money;

        gokker[] gokkerarray = new gokker[1];

        public MainForm()
        {
            InitializeComponent();
            gokkerarray[0] = new gokker() { name = gokkerName, money = 50, moneylabel = moneyLabel};

            gokkerarray[0].updatlabels();

        }
        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JSON = JsonConvert.SerializeObject(Program.gokkerCollection.gokkers);

            string path = "savedData";

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            using (var tw = new StreamWriter(path, true))
            {
                tw.WriteLine(JSON.ToString());
                tw.Close();
            }

            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            loadTeams();
            AntiDepressivaPilletjeNemen();
            loadUsers();
            AntiDepressivaPilletjeNemen();
            loadWedstrijden();
            AntiDepressivaPilletjeNemen();
            loadTypes();
            AntiDepressivaPilletjeNemen();
            loadTeamsComboBox();
            AntiDepressivaPilletjeNemen();

            string path = "savedData";

            if (File.Exists(path))
            {

                List<gokker> LoadedData = null;

                LoadedData = JsonConvert.DeserializeObject<List<gokker>>(File.ReadAllText(@"savedData"));

                Program.gokkerCollection.gokkers = LoadedData;

                for (int i = 0; i < Program.gokkerCollection.gokkers.Count; i++)
                {
                    for (int j = 0; j < Program.gokkerCollection.gokkers[i].weddenschappen.Count; j++)
                    {
                        string newBet = Program.gokkerCollection.gokkers[i].weddenschappen[j].type + " , " +
                                            Program.gokkerCollection.gokkers[i].weddenschappen[j].inzet + " , " +
                                            Program.gokkerCollection.gokkers[i].weddenschappen[j].winnendeTeam + " , " +
                                            Program.gokkerCollection.gokkers[i].weddenschappen[j].eindscore1 + " , " +
                                            Program.gokkerCollection.gokkers[i].weddenschappen[j].eindscore2;

                        betsListBox.Items.Add(newBet);
                    }
                }
            }
        }
        
        public void loadTeams()
        {
            Program.teamList.Clear();

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

                for (int i = 0; i < Program.wedstrijdlist.Count; i++)
                {
                    string team1 = "";
                    string team2 = "";

                    for ( int x = 0; x < Program.teamList.Count; x++ )
                    {
                        if ( Program.teamList[x].id.ToString() == Program.wedstrijdlist[i].team1 )
                        {
                            team1 = Program.teamList[x].teamName;
                        }
                        if ( Program.teamList[x].id.ToString() == Program.wedstrijdlist[i].team2 )
                        {
                            team2 = Program.teamList[x].teamName;
                        }
                    }
                    string wedstrijd = String.Format("{0} - {1}", team1, team2);
                    tournamentsListBox.Items.Add(wedstrijd);
                }
            }
            catch (System.Net.WebException)
            {
                MessageBox.Show("Je hebt geen internet verbinding!");
            }

            Program.wedstrijdlist.Clear();
        }
        
        private void reloadTeamListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            teamsListBox.Items.Clear();
            loadTeams();

            winningTeamComboBox.Items.Clear();
            loadTeamsComboBox();
        }
        
        public void loadTypes()
        {
            string[] types = new string[2];
            types[0] = "Double or Nothing";
            types[1] = "Tripple or Nothing";

            typeBetComboBox.Items.Add(types[0]);
            typeBetComboBox.Items.Add(types[1]);
        }

        public void loadTeamsComboBox()
        {
            for (int i = 0; i < teamsListBox.Items.Count ; i++)
            {
                string[] teams = new string[teamsListBox.Items.Count];
                teams[i] = teamsListBox.GetItemText(teamsListBox.Items[i]);

                winningTeamComboBox.Items.Add(teams[i]);
            }
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
            int counter = 0;

            if (typeBetComboBox.SelectedItem == null)
            {
                MessageBox.Show("Vul een weddenschap type in");
                counter = counter + 1;
            }

            if (typeBetComboBox.SelectedItem != null &&
                amountNumeric.Value <= 4 &&
                typeBetComboBox.SelectedItem.ToString() == "Double or Nothing")
            {
                MessageBox.Show("Vul een inzet in van minimaal 5");
                counter = counter + 1;
            }

            if (typeBetComboBox.SelectedItem != null &&
                amountNumeric.Value == 0 &&
                typeBetComboBox.SelectedItem.ToString() == "Tripple or Nothing")
            {
                MessageBox.Show("Vul een inzet in van minimaal 15");
                counter = counter + 1;
            }

            if (typeBetComboBox.SelectedItem != null &&
                winningTeamComboBox.SelectedItem == null)
            {
                MessageBox.Show("Vul het winnende team in");
                counter = counter + 1;
            }

            if (typeBetComboBox.SelectedItem != null &&
                typeBetComboBox.SelectedItem.ToString() == "Tripple or Nothing" &&
                endScoreTeam1Numeric.Value <= -1 &&
                endScoreTeam2Numeric.Value <= -1)
            {
                MessageBox.Show("Vul de eindscore in");
                counter = counter + 1;
            }

            if (counter == 0)
            {
                for (int i = 0; i < Program.gokkerCollection.gokkers.Count; i++)
                {
                    if (Program.gokkerCollection.gokkers[i].name == nameLabel.Text)
                    {
                        money = Program.gokkerCollection.gokkers[i].money;
                    }
                }
                        
                if (money < amountNumeric.Value)
                {
                    MessageBox.Show("je hebt niet genoeg geld!!!");
                    return;
                }

                for (int i = 0; i < Program.gokkerCollection.gokkers.Count; i++)
                {
                    if (Program.gokkerCollection.gokkers[i].name == gokkerName)
                    {
                        Program.gokkerCollection.gokkers[i].makebet(typeBetComboBox.GetItemText(typeBetComboBox.SelectedItem),
                                       (int)amountNumeric.Value,
                                       winningTeamComboBox.SelectedItem.ToString(),
                                       (int)endScoreTeam1Numeric.Value,
                                       (int)endScoreTeam2Numeric.Value);
                        if (typeBetComboBox.GetItemText(typeBetComboBox.SelectedItem) == "Tripple or Nothing")
                        {
                            string newBet = typeBetComboBox.GetItemText(typeBetComboBox.SelectedItem) + " , " +
                                        (int)amountNumeric.Value + " , " +
                                        winningTeamComboBox.SelectedItem.ToString() + " , " +
                                        (int)endScoreTeam1Numeric.Value + " , " +
                                        (int)endScoreTeam2Numeric.Value;

                            betsListBox.Items.Add(newBet);
                        }

                        if (typeBetComboBox.GetItemText(typeBetComboBox.SelectedItem) == "Double or Nothing")
                        {
                            string newBet = typeBetComboBox.GetItemText(typeBetComboBox.SelectedItem) + " , " +
                                        (int)amountNumeric.Value + " , " +
                                        winningTeamComboBox.SelectedItem.ToString();

                            betsListBox.Items.Add(newBet);
                        }
                    }
                }
                
                for (int i = 0; i < Program.gokkerCollection.gokkers.Count; i++)
                {
                    if (Program.gokkerCollection.gokkers[i].name == gokkerName)
                    {
                        int nummer = (int)amountNumeric.Value;
                        int geld = (int)Program.gokkerCollection.gokkers[i].money;
                        int money = geld - nummer;

                        Program.gokkerCollection.gokkers[i].money = money;
                        moneyLabel.Text = money.ToString();
                        
                    }
                }
                
            }
            
        }
          
        public void AntiDepressivaPilletjeNemen()
        {
            System.Threading.Thread.Sleep(500);
        }

        private void loginToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();

            if (Program.isLoggedIn)
            {
                MakeAGokkerGroupBox.Enabled = true;
                refreshExistingGokkers();
            }
        }

        public void refreshExistingGokkers()
        {
            existingGokkerComboBox.Items.Clear();

            for (int i = 0; i < Program.gokkerCollection.gokkers.Count; i++)
            {
                existingGokkerComboBox.Items.Add(Program.gokkerCollection.gokkers[i].name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (gokkerNameTextBox.Text == "Motherload" || gokkerNameTextBox.Text == "Klapaucius" || gokkerNameTextBox.Text == "Rosebud")
            {
                if (gokkerNameTextBox.Text == "Motherload")
                {
                    for (int i = 0; i < Program.gokkerCollection.gokkers.Count; i++)
                    {
                        if (Program.gokkerCollection.gokkers[i].name == gokkerName)
                        {
                            Program.gokkerCollection.gokkers[i].money = Program.gokkerCollection.gokkers[i].money + 50000;
                            moneyLabel.Text = Program.gokkerCollection.gokkers[i].money.ToString();
                            return;
                        }
                    }

                }

                if (gokkerNameTextBox.Text == "Klapaucius")
                {
                    for (int i = 0; i < Program.gokkerCollection.gokkers.Count; i++)
                    {
                        if (Program.gokkerCollection.gokkers[i].name == gokkerName)
                        {
                            Program.gokkerCollection.gokkers[i].money = Program.gokkerCollection.gokkers[i].money + 1000;
                            moneyLabel.Text = Program.gokkerCollection.gokkers[i].money.ToString();
                            return;
                        }
                    }
                }

                if (gokkerNameTextBox.Text == "Rosebud")
                {
                    for (int i = 0; i < Program.gokkerCollection.gokkers.Count; i++)
                    {
                        if (Program.gokkerCollection.gokkers[i].name == gokkerName)
                        {
                            Program.gokkerCollection.gokkers[i].money = Program.gokkerCollection.gokkers[i].money + 1000;
                            moneyLabel.Text = Program.gokkerCollection.gokkers[i].money.ToString();
                            return;
                        }
                    }
                }

                return;
            }

            gokkerName = gokkerNameTextBox.Text;
            
            Program.gokkerCollection.makeGokker(gokkerName);

            MessageBox.Show("de gokker is aangemaakt");
            nameLabel.Text = gokkerName;
            makeBetGroupBox.Enabled = true;
            refreshExistingGokkers();
        }

        private void useExistingGokkerButton_Click(object sender, EventArgs e)
        {
            gokkerName = existingGokkerComboBox.SelectedItem.ToString();
            nameLabel.Text = gokkerName;
            makeBetGroupBox.Enabled = true;
            moneyLabel.Text = "0";

            for (int i = 0; i < Program.gokkerCollection.gokkers.Count; i++)
            {
                if (Program.gokkerCollection.gokkers[i].name == gokkerName)
                {
                    moneyLabel.Text = Program.gokkerCollection.gokkers[i].money.ToString();
                }
            }

        }

        private void typeBetComboBox_Enter(object sender, EventArgs e)
        {
            endScoreTeam1Numeric.Value = 0;
            endScoreTeam2Numeric.Value = 0;
            amountNumeric.Value = 5;
        }
    }
}
