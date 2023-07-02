using Newtonsoft.Json;

namespace ApiApp.Models
{
    public class Author
    {
        [JsonProperty("ID")]
        public virtual int AuthorId { get; set; }

        [JsonProperty("first_name")]
        public virtual string FirstName { get; set; } = "tom";

        [JsonProperty("last_name")]
        public virtual string Surname { get; set; } = "schenkels";

        public virtual string Name { get; set; } = "toms";
    }
}