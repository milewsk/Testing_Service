using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Testing_Service.Context;
using Testing_Service.Models;

namespace Testing_Service.Pages
{
    public class Pobrane_z_bazyModel : PageModel
    {

        private readonly ProductContext _context;

        public Product product1;
        //lista produktów 
        public IList<Product> Products { get; private set; }
   
        public Pobrane_z_bazyModel(ProductContext context)
        {
            _context = context;
        }
        
        public void OnGet()
        {
            var Query = from prod in _context.Products select prod;

            Products = Query.ToList();
        }
    }
}
