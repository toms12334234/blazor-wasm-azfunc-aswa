using System;
using System.Collections.Generic;


using Newtonsoft.Json;

namespace ApiApp.Models
{
    public class PostItem
    {
        [JsonProperty("ID")]
        public virtual int PostId { get; set; }

        public virtual Author Author { get; set; } = new();

        [JsonProperty("date")]
        public virtual DateTimeOffset DatePublished { get; set; }

        public virtual string Title { get; set; } = "newTitle";

        [JsonProperty("URL")]
        public virtual string Url { get; set; } = "newUrl";

        public virtual string Excerpt { get; set; } = "newExcerpt";

        public virtual string Content { get; set; } = "newContent";

        public virtual Dictionary<string, Category> Categories { get; set; } = new();

        public override string ToString() => $"Title: '{Title}', Categories: [{string.Join(',', Categories.Keys)}]";
    }
}