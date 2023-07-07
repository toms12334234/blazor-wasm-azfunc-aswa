using Newtonsoft.Json;

namespace ApiApp.Models
{
    public class Category
    {
        [JsonProperty("ID")]
        public virtual int CategoryId { get; set; }

        [JsonProperty("name")]
        public virtual string CategoryName { get; set; } = "MyCategoryName";

        [JsonProperty("parent")]
        public virtual int CategoryParentId { get; set; }

    }
}