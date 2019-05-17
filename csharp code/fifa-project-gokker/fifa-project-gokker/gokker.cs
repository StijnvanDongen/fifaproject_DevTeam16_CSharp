using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fifa_project_gokker
{
    class gokker
    {
        public string name { get; set; }
        public decimal money { get; set; }
        
        public List<weddenschap> weddenschappen = new List<weddenschap>();
        public Label moneylabel;

        public void updatlabels()
        {
            moneylabel.Text = "$" + money.ToString();
        }

        public void makebet(string betType, int betValue, string betWinningTeam, int betScore1, int betScore2)
        {
            int i = weddenschappen.Count() + 1;
            string betName = "bet" + i.ToString();

            weddenschap bet = new weddenschap();

            bet.betName = betName;
            bet.type = betType;
            bet.inzet = betValue;
            bet.winnendeTeam = betWinningTeam;
            bet.eindscore1 = betScore1;
            bet.eindscore2 = betScore2;

            weddenschappen.Add(bet);

            
        }
    }
}
