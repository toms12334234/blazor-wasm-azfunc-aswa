using System.Collections.Generic;

using Newtonsoft.Json;

namespace ApiApp.Models
{
    public class Metadata
    {
        public virtual Dictionary<string, string> Links { get; set; } = new();

        [JsonProperty("wpcom")]
        public virtual bool IsWordpressCom { get; set; }
    }
}