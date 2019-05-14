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
        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("teamName")]
        public string teamName { get; set; }

        [JsonProperty("madeBy")]
        public string madeBy { get; set; }
    }
}
