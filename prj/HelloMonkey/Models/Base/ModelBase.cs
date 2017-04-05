using System;
using Newtonsoft.Json;

namespace HelloMonkey.Models
{
    public class ModelBase
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        public ModelBase()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
