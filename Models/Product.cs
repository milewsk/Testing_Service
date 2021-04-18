using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Testing_Service.Models
{
    public class Product
    {
        
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [MaxLength(40)]
        [JsonPropertyName("maker")]
        public string Maker { get; set; }

        [JsonPropertyName("img")]
        public string Image { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [MaxLength(100)]
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Product>(this);
        
           
        
    }
}
