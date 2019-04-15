using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fifa_project_gokker
{
    class data
    {
        [JsonProperty("teamName")]
        public string teamName { get; set; }

        [JsonProperty("player1")]
        public string player1 { get; set; }

        [JsonProperty("player2")]
        public string player2 { get; set; }

        [JsonProperty("player3")]
        public string player3 { get; set; }

        [JsonProperty("player4")]
        public string player4 { get; set; }

        [JsonProperty("player5")]
        public string player5 { get; set; }

        [JsonProperty("player6")]
        public string player6 { get; set; }

        [JsonProperty("player7")]
        public string player7 { get; set; }

        [JsonProperty("player8")]
        public string player8 { get; set; }

        [JsonProperty("player9")]
        public string player9 { get; set; }

        [JsonProperty("player10")]
        public string player10 { get; set; }

        [JsonProperty("player11")]
        public string player11 { get; set; }

        [JsonProperty("madeBy")]
        public string madeBy { get; set; }
    }
}
