using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fifa_project_gokker
{
    class GokkerCollection
    {
        public List<gokker> gokkers = new List<gokker>();

        public void makeGokker(string gokkerName)
        {
            gokker Gokker = new gokker();

            Gokker.name = gokkerName;

            gokkers.Add(Gokker);
        }
    }
}
