using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoCrafts.WebSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceInjection.Data2;

namespace ServiceInjection.Pages
{
    public class Pobrane_z_bazyModel : PageModel
    {
        private readonly ProductsContext _context;
        public IList<Product> Products { get; set; }
        public Pobrane_z_bazyModel( ProductsContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            Products = _context.Product.ToList();
        }
    }
}
