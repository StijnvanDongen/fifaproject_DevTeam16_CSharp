using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fifa_project_gokker
{
    public class weddenschap
    {
        public int id { get; set; }
        public string betName { get; set; }
        public string type { get; set; }
        public decimal inzet { get; set; }
        public string winnendeTeam { get; set; }
        public int eindscore1 { get; set; }
        public int eindscore2 { get; set; }
        public string betMadeBy { get; set; }
        public int idGame { get; set; }

        public decimal uitbetalen(string winner, ComboBox acombobox)
        {
            if (acombobox.SelectedItem.ToString() == "Double or Nothing")
            {
                if (winner == winnendeTeam)
                {
                    return (inzet * 2);
                }
                else
                {
                    return (0 - inzet);
                }
            }
            return inzet;
        }
    }
}
