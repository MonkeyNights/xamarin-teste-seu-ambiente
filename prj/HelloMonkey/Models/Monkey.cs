using System;
using Newtonsoft.Json;

namespace HelloMonkey.Models
{
    public class Monkey : ModelBase
    {
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }

        [JsonProperty("miniBio")]
        public string MiniBio
        {
            get;
            set;
        }

        [JsonProperty("avatarUrl")]
        public string AvatarUrl
        {
            get;
            set;
        }

        [JsonProperty("twitter")]
        public string Twitter
        {
            get;
            set;
        }
    }
}
