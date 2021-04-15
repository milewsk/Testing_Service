using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Testing_Service.Services;
using Testing_Service.Models;

namespace Testing_Service.Pages
{
    public class Pobrane_z_plikuModel : PageModel
    {
        private JsonFileProductService _jsonFileProduct;

        public Product product1;
        //lista produktów 
        public IEnumerable<Product> Products { get; private set; }
        
        public Pobrane_z_plikuModel(JsonFileProductService jsonFileProduct)
        {
            _jsonFileProduct = jsonFileProduct;
        }

        public void OnGet()
        {
            Products = _jsonFileProduct.GetProducts();
        }
    }
}
