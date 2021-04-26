using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoCrafts.WebSite.Models;
using ContosoCrafts.WebSite.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceInjection.Pages
{
    public class Pobrane_z_plikuModel : PageModel
    {
        public JsonFileProductService ProductService;
        public IEnumerable<Product> Products { get; private set; }
        public Pobrane_z_plikuModel(JsonFileProductService productService)
        {
            ProductService = productService;
        }

        public void OnGet()
        {
            Products = ProductService.GetProducts();
        }
    }
}
