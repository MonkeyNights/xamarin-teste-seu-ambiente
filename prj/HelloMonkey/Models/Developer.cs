using System;
using Newtonsoft.Json;

namespace HelloMonkey.Models
{
    public class Developer : ModelBase
    {
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }

        [JsonProperty("email")]
        public object Email
        {
            get;
            set;
        }

        [JsonProperty("city")]
        public string City
        {
            get;
            set;
        }

        [JsonProperty("state")]
        public string State
        {
            get;
            set;
        }
    }
}
