using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Testing_Service.Models
{
    public class Product
    {
        public int id { get; set; }

        [JsonPropertyName("maker")]
        public string Maker { get; set; }

        [JsonPropertyName("img")]
        public string Image { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("descripton")]
        public string Description { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Product>(this);
        
           
        
    }
}
