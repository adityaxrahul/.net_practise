using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Pratical_6_1.Models;

namespace Pratical_6_1.Controllers
{
    public class ProductController : Controller
    {
        private static List<Product> products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Laptop",
                Category = "Electronics",
                Price = 55000,
                Description = "High performance laptop"
            },

            new Product
            {
                Id = 2,
                Name = "Smartphone",
                Category = "Electronics",
                Price = 25000,
                Description = "Modern smartphone"
            },

            new Product
            {
                Id = 3,
                Name = "Headphones",
                Category = "Accessories",
                Price = 2500,
                Description = "Wireless headphones"
            }
        };

        public ActionResult Index()
        {
            return View(products);
        }

        public ActionResult Details(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                return HttpNotFound();
            }

            return View(product);
        }
    }
}