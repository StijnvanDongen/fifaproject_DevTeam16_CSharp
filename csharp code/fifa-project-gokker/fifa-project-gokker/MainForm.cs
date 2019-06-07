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
        public string JSONCounter = "";
        public int idCounter = 0;
        public int idwinnendeteam = 0;

        decimal money;

        gokker[] gokkerarray = new gokker[1];

        public MainForm()
        {
            InitializeComponent();
            gokkerarray[0] = new gokker() { name = gokkerName, money = 50, moneylabel = moneyLabel};

            gokkerarray[0].updatlabels();

        }

        private void sluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JSON = JsonConvert.SerializeObject(Program.gokkerCollection.gokkers);
            JSONCounter = JsonConvert.SerializeObject(idCounter);

            string path = "savedData";
            string path2 = "idCounterSaved";

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            if (File.Exists(path2))
            {
                File.Delete(path2);
            }

            using (var tw = new StreamWriter(path, true))
            {
                tw.WriteLine(JSON.ToString());
                tw.Close();
            }

            using (var tw = new StreamWriter(path2, true))
            {
                tw.WriteLine(JSONCounter.ToString());
                tw.Close();
            }

                this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // hier word alle data ingeladen.
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
            refreshExistingGokkers();

            string path = "savedData";
            string path2 = "idCounterSaved";

            // er word gekeken of er een bestand bestaat waar opgeslagen data in aanwezig is.
            if (File.Exists(path))
            {

                List<gokker> LoadedData = null;

                LoadedData = JsonConvert.DeserializeObject<List<gokker>>(File.ReadAllText(@"savedData"));
                
                Program.gokkerCollection.gokkers = LoadedData;
                // opgeslagen data is opgeslagen in de applicate
                for (int i = 0; i < Program.gokkerCollection.gokkers.Count; i++)
                {
                    for (int j = 0; j < Program.gokkerCollection.gokkers[i].weddenschappen.Count; j++)
                    {
                        idCounter++;

                        if (Program.gokkerCollection.gokkers[i].weddenschappen[j].type == "Double or Nothing")
                        {
                            // de opgehaalde Double or Nothing weddenschappen worden opgebouwd en weergegeven op het scherm
                            string bet = Program.gokkerCollection.gokkers[i].weddenschappen[j].id + " , " +
                                         Program.gokkerCollection.gokkers[i].weddenschappen[j].type + " , " +
                                         Program.gokkerCollection.gokkers[i].weddenschappen[j].inzet + " , " +
                                         Program.gokkerCollection.gokkers[i].weddenschappen[j].winnendeTeam + " , " +
                                         Program.gokkerCollection.gokkers[i].weddenschappen[j].idGame;


                            betsListBox.Items.Add(bet);
                        }

                        if (Program.gokkerCollection.gokkers[i].weddenschappen[j].type == "Tripple or Nothing")
                        {
                            // de opgehaalde Tripple or Nothing weddenschappen worden opgebouwd en weergegeven op het scherm
                            string bet = Program.gokkerCollection.gokkers[i].weddenschappen[j].id + " , " +
                                         Program.gokkerCollection.gokkers[i].weddenschappen[j].type + " , " +
                                         Program.gokkerCollection.gokkers[i].weddenschappen[j].inzet + " , " +
                                         Program.gokkerCollection.gokkers[i].weddenschappen[j].winnendeTeam + " , " +
                                         Program.gokkerCollection.gokkers[i].weddenschappen[j].eindscore1 + " , " +
                                         Program.gokkerCollection.gokkers[i].weddenschappen[j].eindscore2 + " , " +
                                         Program.gokkerCollection.gokkers[i].weddenschappen[j].idGame;

                            betsListBox.Items.Add(bet);
                        }
                    }
                }
            }

            if (File.Exists(path2))
            {
                // er word een id opgehaald voor het geven van een id aan de weddenschappen
                int Loadedid = 0;
                Loadedid = JsonConvert.DeserializeObject<int>(File.ReadAllText(@"idCounterSaved"));
                idCounter = Loadedid;
            }
        }
        
        public void loadTeams()
        {
            // hier worden de teamlists leeg gemaakt
            Program.teamList.Clear();
            teamsListBox.Items.Clear();

            // er word een webclient aan gemaakt voor het downloaden van de data uit de api en die data word in de applicatie geladen.
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
            // hier worden de gebruikers (accounts van de website) ingeladen via de api doormiddel van een webclient.
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
            // eerst word de combobox leeg gemaakt 
            WedstrijdIDComboBox.Items.Clear();
            // en nu worden alle wedstrijden overal ingeladen (ook via een webclient die download vanaf de api)
            try
            {
                tournamentsListBox.Items.Clear();
                WebClient webClient = new WebClient();
                string wedstrijdenjson = webClient.DownloadString(WEDSTRIJDENAPI_URL);

                dataWedstrijden[] wedstrijden = JsonConvert.DeserializeObject<dataWedstrijden[]>(wedstrijdenjson);

                foreach (dataWedstrijden wedstrijd in wedstrijden)
                {
                    // ingeladen wedstrijden worden in de list gezet
                    Program.wedstrijdlist.Add(wedstrijd);
                }

                for (int i = 0; i < Program.wedstrijdlist.Count; i++)
                {
                    // hier worden de teams aan de juiste wedstrijden gekoppeld en weergeven in de listbox voor wedstrijden en in de combobox.
                    string team1 = "";
                    string team2 = "";
                    int id = Program.wedstrijdlist[i].id;

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
                    string wedstrijd = String.Format("{0} - {1} - {2}", id ,team1, team2 );
                    tournamentsListBox.Items.Add(wedstrijd);
                    WedstrijdIDComboBox.Items.Add(id);
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
            // hier kan je nog wat data opnieuw inladen die uit de api komt.
            teamsListBox.Items.Clear();
            loadTeams();

            winningTeamComboBox.Items.Clear();
            loadTeamsComboBox();
        }
        
        public void loadTypes()
        {
            // hier worden de types double/tripple or nothing nog toegevoegd
            string[] types = new string[2];
            types[0] = "Double or Nothing";
            types[1] = "Tripple or Nothing";

            typeBetComboBox.Items.Add(types[0]);
            typeBetComboBox.Items.Add(types[1]);
        }

        public void loadTeamsComboBox()
        {
            // met deze forloop worden alle teams in de combobox voor het gokken gezet
            for (int i = 0; i < teamsListBox.Items.Count ; i++)
            {
                string[] teams = new string[teamsListBox.Items.Count];
                teams[i] = teamsListBox.GetItemText(teamsListBox.Items[i]);

                winningTeamComboBox.Items.Add(teams[i]);
            }
        }

        private void typeBetComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // dit is zodat als je een double or nothing weddenschap na een tripple or nothing plaatst je geen eind score kan invullen.
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
            idwinnendeteam = (int)WedstrijdIDComboBox.SelectedItem;

            if(WedstrijdIDComboBox.SelectedItem == null)
            {
                MessageBox.Show("vul een wedstrijd id in");
            }

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

            // als er iets fout gaat in het aanmaken van een weddenschap gaat de counter omhoog en gaat de applicatie niet door met het
            // maken van de weddenschap totdat alles correct is 

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
                        idCounter = idCounter + 1;
                        // hier word de weddenschap aangemaakt en de juiste waardes worden mee gegeven.
                        Program.gokkerCollection.gokkers[i].makebet(idCounter, typeBetComboBox.GetItemText(typeBetComboBox.SelectedItem),
                                       (int)amountNumeric.Value,
                                       winningTeamComboBox.SelectedItem.ToString(),
                                       (int)endScoreTeam1Numeric.Value,
                                       (int)endScoreTeam2Numeric.Value,
                                       gokkerName,
                                       idwinnendeteam);

                        // hier onder word er gekeken of de weddenschap double/tripple or nothing is en zo word bepaald hoe 
                        // de weddenschap word weergeven in de lijst.
                        if (typeBetComboBox.GetItemText(typeBetComboBox.SelectedItem) == "Tripple or Nothing")
                        {
                            string newBet = idCounter + " , " +
                                        typeBetComboBox.GetItemText(typeBetComboBox.SelectedItem) + " , " +
                                        (int)amountNumeric.Value + " , " +
                                        winningTeamComboBox.SelectedItem.ToString() + " , " +
                                        (int)endScoreTeam1Numeric.Value + " , " +
                                        (int)endScoreTeam2Numeric.Value + " , " +
                                        idwinnendeteam;

                            betsListBox.Items.Add(newBet);
                        }

                        if (typeBetComboBox.GetItemText(typeBetComboBox.SelectedItem) == "Double or Nothing")
                        {
                            string newBet = idCounter + " , " +
                                        typeBetComboBox.GetItemText(typeBetComboBox.SelectedItem) + " , " +
                                        (int)amountNumeric.Value + " , " +
                                        winningTeamComboBox.SelectedItem.ToString() + " , " +
                                        idwinnendeteam.ToString();

                            betsListBox.Items.Add(newBet);
                        }
                    }
                }
                
                for (int i = 0; i < Program.gokkerCollection.gokkers.Count; i++)
                {
                    // hier word er gezorgd dat het geld word afgeschreven van je gokker wanner de weddenschap geplaatst is.
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

        public void loadwedstrijdenlistbox()
        {
            // dit is zodat de wedstrijden list netjes kan worden ingeladen.
            betsListBox.Items.Clear();

            for (int i = 0; i < Program.gokkerCollection.gokkers.Count; i++)
            {
                for (int j = 0; j < Program.gokkerCollection.gokkers[i].weddenschappen.Count; j++)
                {
                    if (Program.gokkerCollection.gokkers[i].weddenschappen[j].type == "Double or Nothing")
                    {
                        string bet = Program.gokkerCollection.gokkers[i].weddenschappen[j].type + " , " +
                                     Program.gokkerCollection.gokkers[i].weddenschappen[j].inzet + " , " +
                                     Program.gokkerCollection.gokkers[i].weddenschappen[j].winnendeTeam + " , " +
                                     Program.gokkerCollection.gokkers[i].weddenschappen[j].idGame;

                        betsListBox.Items.Add(bet);
                    }

                    if (Program.gokkerCollection.gokkers[i].weddenschappen[j].type == "Tripple or Nothing")
                    {
                        string bet = Program.gokkerCollection.gokkers[i].weddenschappen[j].type + " , " +
                                     Program.gokkerCollection.gokkers[i].weddenschappen[j].inzet + " , " +
                                     Program.gokkerCollection.gokkers[i].weddenschappen[j].winnendeTeam + " , " +
                                     Program.gokkerCollection.gokkers[i].weddenschappen[j].eindscore1 + " , " +
                                     Program.gokkerCollection.gokkers[i].weddenschappen[j].eindscore2 + " , " +
                                     Program.gokkerCollection.gokkers[i].weddenschappen[j].idGame;

                        betsListBox.Items.Add(bet);
                    }
                }
            }
        }
          
        public void AntiDepressivaPilletjeNemen()
        {
            // dit is zodat het programma even 500ms wacht tot hij door gaat (voornamelijk gebruikt bij het opstarten op fouten te voorkomen.)
            System.Threading.Thread.Sleep(500);
        }

        private void loginToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // hiermee word het login form geopent zodat je kan inloggen.
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
            //voor het gebruiken van bestaande gokkers moeten de bestaande gokkers worden ingeladen dat word hier gedaan.
            existingGokkerComboBox.Items.Clear();
            avaliblecomboBox.Items.Clear();

            for (int i = 0; i < Program.gokkerCollection.gokkers.Count; i++)
            {
                existingGokkerComboBox.Items.Add(Program.gokkerCollection.gokkers[i].name);
                avaliblecomboBox.Items.Add(Program.gokkerCollection.gokkers[i].name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // hier word alles gedaan voor de cheatcodes en vooral om onderscheid te maken tussen een gokker aanmaken en een cheatcode 
            // invullen 
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
            // als we zeker weten dat het niet om een cheatcode gaat word er een gokker aangemaakt.

            gokkerName = gokkerNameTextBox.Text;
            
            Program.gokkerCollection.makeGokker(gokkerName);

            MessageBox.Show("de gokker is aangemaakt");
            nameLabel.Text = gokkerName;
            makeBetGroupBox.Enabled = true;
            refreshExistingGokkers();
        }

        private void useExistingGokkerButton_Click(object sender, EventArgs e)
        {
            // deze knop word gebruikt als je een al bestaande gokker wilt gebruiken

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

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // alles dat refreshed kan worden. 
            loadTeams();
            AntiDepressivaPilletjeNemen();
            loadWedstrijden();
            AntiDepressivaPilletjeNemen();
            loadwedstrijdenlistbox();
        }

        private void avaliblecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = avaliblecomboBox.SelectedItem.ToString();
            // hier word er voor gezorgd dat de weddenschappen van de geselecteerde gokker in de list komen te staan 

            for (int i = 0; i < Program.gokkerCollection.gokkers.Count; i++)
            {
                if (Program.gokkerCollection.gokkers[i].name == name)
                {
                    gokkerName = name;
                    betspergokkerListBox.Items.Clear();
                    for (int j = 0; j < Program.gokkerCollection.gokkers[i].weddenschappen.Count; j++)
                    {
                        betspergokkerListBox.Items.Add(  Program.gokkerCollection.gokkers[i].weddenschappen[j].id + " - " +
                                                         Program.gokkerCollection.gokkers[i].weddenschappen[j].type + " - " + 
                                                         Program.gokkerCollection.gokkers[i].weddenschappen[j].winnendeTeam + " - " +
                                                         Program.gokkerCollection.gokkers[i].weddenschappen[j].idGame);
                    }
                }
            }
        }

        private void payoutButton_Click(object sender, EventArgs e)
        {
            PayOutLogic();
        }

        public void PayOutLogic()
        {
            for (int i = 0; i < betspergokkerListBox.SelectedItems.Count; i++)
            {
                for (int j = 0; j < Program.gokkerCollection.gokkers.Count; j++)
                {
                    if (Program.gokkerCollection.gokkers[j].name == gokkerName)
                    {
                        var betdata = Program.gokkerCollection.gokkers[j].weddenschappen[betspergokkerListBox.SelectedIndex].id.ToString();

                        bool winningteam()
                        {
                            if (Program.gokkerCollection.gokkers[j].weddenschappen[betspergokkerListBox.SelectedIndex].eindscore1 > Program.gokkerCollection.gokkers[j].weddenschappen[betspergokkerListBox.SelectedIndex].eindscore2)
                            {
                                //team 1 wint
                                for (int q = 0; q < Program.wedstrijdlist.Count; q++)
                                {
                                    if (Program.wedstrijdlist[q].team1 == Program.gokkerCollection.gokkers[j].weddenschappen[betspergokkerListBox.SelectedIndex].winnendeTeam)
                                    {
                                        MessageBox.Show(Program.wedstrijdlist[q].team1);
                                    }
                                }
                                return false;
                            }
                            else
                            {
                                //team 2 wint
                                for (int q = 0; q < Program.wedstrijdlist.Count; q++)
                                {
                                    if (Program.wedstrijdlist[q].team2 == Program.gokkerCollection.gokkers[j].weddenschappen[betspergokkerListBox.SelectedIndex].winnendeTeam)
                                    {
                                        MessageBox.Show(Program.wedstrijdlist[q].team2);
                                    }
                                }
                                return true;
                            }
                        }

                        if (Program.gokkerCollection.gokkers[j].weddenschappen[betspergokkerListBox.SelectedIndex].type == "Double or Nothing")
                        {
                            if (winningteam() == false )
                            {
                                var payout = Program.gokkerCollection.gokkers[j].weddenschappen[betspergokkerListBox.SelectedIndex].inzet * 2;
                                Program.gokkerCollection.gokkers[j].money = Program.gokkerCollection.gokkers[j].money + payout;
                            }
                            else if (winningteam() == true)
                            {
                                var payout = Program.gokkerCollection.gokkers[j].weddenschappen[betspergokkerListBox.SelectedIndex].inzet * 2;
                                Program.gokkerCollection.gokkers[j].money = Program.gokkerCollection.gokkers[j].money + payout;
                            }
                        }

                        if (Program.gokkerCollection.gokkers[j].weddenschappen[betspergokkerListBox.SelectedIndex].type == "Tripple or Nothing")
                        {
                            if (winningteam() == false)
                            {
                                var payout = Program.gokkerCollection.gokkers[j].weddenschappen[betspergokkerListBox.SelectedIndex].inzet * 3;
                                Program.gokkerCollection.gokkers[j].money = Program.gokkerCollection.gokkers[j].money + payout;
                            }
                            else if (winningteam() == true)
                            {
                                var payout = Program.gokkerCollection.gokkers[j].weddenschappen[betspergokkerListBox.SelectedIndex].inzet * 3;
                                Program.gokkerCollection.gokkers[j].money = Program.gokkerCollection.gokkers[j].money + payout;
                            }
                        }

                        moneyLabel.Text = Program.gokkerCollection.gokkers[j].money.ToString();
                    }
                }
            }
        }

        
    }
}
