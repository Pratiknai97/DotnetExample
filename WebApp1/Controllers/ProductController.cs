using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp1.Model;

namespace WebApp1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    
    {
        [HttpGet]
        public IActionResult Getdata()
        {
            Product p1 = new Product();
            p1.ID = 1;
            p1.PName = "KeyBoard";
            p1.Rate = 1500;
            Product p2 = new Product();
            p2.ID = 2;
            p2.PName = "Mouse";
            p2.Rate = 1000;
            List<Product> products = new List<Product>();
            products.Add(p1);
            products.Add(p2);
            
            return Ok(products);
        }
    }
}
