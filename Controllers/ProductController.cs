
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Practical6.Models;

namespace Practical6.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            List<Product> products = GetProducts();
            return View(products);
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
                return RedirectToAction("Index");

            List<Product> products = GetProducts();

            Product product = products.FirstOrDefault(
                p => p.ProductId == id.Value
            );

            if (product == null)
                return HttpNotFound();

            return View(product);
        }

        private List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    ProductId = 1,
                    ProductName = "Laptop",
                    Description = "Lenovo Laptop",
                    Price = 55000,
                    Category = "Electronics"
                },
                new Product
                {
                    ProductId = 2,
                    ProductName = "Mobile",
                    Description = "Samsung Mobile",
                    Price = 25000,
                    Category = "Electronics"
                },
                new Product
                {
                    ProductId = 3,
                    ProductName = "Shoes",
                    Description = "Nike Shoes",
                    Price = 5000,
                    Category = "Footwear"
                }
            };
        }
    }
}
