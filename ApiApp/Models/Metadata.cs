using System.Collections.Generic;

using Newtonsoft.Json;

namespace ApiApp.Models
{
    public class Metadata
    {
        public virtual Dictionary<string, string> Links { get; set; } = new();

        [JsonProperty("next_page", Required = Required.AllowNull)]
        public virtual string? NextPage { get; set; }

        [JsonProperty("wpcom")]
        public virtual bool IsWordpressCom { get; set; }
    }
}