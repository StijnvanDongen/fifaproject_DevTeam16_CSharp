using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fifa_project_gokker
{
    public class dataWedstrijden
    {
        [JsonProperty("team1")]
        public string team1 { get; set; }

        [JsonProperty("team2")]
        public string team2 { get; set; }
    }
}
