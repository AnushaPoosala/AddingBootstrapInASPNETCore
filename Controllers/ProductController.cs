using AddingBootstrapInASPNETCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace AddingBootstrapInASPNETCore.Controllers
{
    public class ProductController : Controller
    {
        List<Product> products;
        public ProductController() 
        {
            products = new List<Product>() { 
                new Product() {ProductId=1,Name="LG",CategoryName="Digital",Description="Mobile",IsAvailable=true }, 
                new Product() { ProductId=2,Name="LG",CategoryName="Digital",Description="Mobile",IsAvailable=true},
                new Product() {ProductId=3,Name="LG",CategoryName="Digital",Description="Mobile",IsAvailable=true },
                new Product() {ProductId=4,Name="LG",CategoryName="Digital",Description="Mobile",IsAvailable=true },
                new Product() { ProductId=5,Name="LG",CategoryName="Digital",Description="Mobile",IsAvailable=true}
            };
        }
        public IActionResult Index()
        {
            return View(products);
        }
        public IActionResult Details(int prodNo)
        {
            var productsInfo = products.Where(p => p.ProductId == prodNo).FirstOrDefault();
            return View(productsInfo);
        }

        public IActionResult Login()
        {
            return View();
        }

    }
}
