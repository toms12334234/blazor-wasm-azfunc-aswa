using System.Collections.Generic;

using Newtonsoft.Json;

namespace ApiApp.Models
{
    public class PostCollection
    {

        public virtual List<PostItem> Posts { get; set; } = new();

    }
}