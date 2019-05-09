using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fifa_project_gokker
{
    class dataUsers
    {
        [JsonProperty("userName")]
        public string userName { get; set; }

        [JsonProperty("email")]
        public string email { get; set; }

        [JsonProperty("password")]
        public string password { get; set; }

        [JsonProperty("admin")]
        public string admin { get; set; }
    }
}