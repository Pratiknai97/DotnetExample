using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp1.Model;

namespace WebApp1.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    
    {
        private List<Product> GetProducts()
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
            return products;
        }
        [HttpGet]
          
        public IActionResult Getdata()
        {
            List<Product> products = GetProducts();
            
            return Ok(products);
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetbyId(int id) 
        {

            List<Product> products = GetProducts();
            
            var Result = products.Where(x => x.ID == id).FirstOrDefault();
            
            if(Result ==null)
            {
                return NotFound();
            }
                        
            return Ok(Result);
        }
        [HttpGet]
        [Route("{Rate}")]

        public IActionResult GetbyRate(int Rate)
        {
            List<Product> products = GetProducts();

            var rate = products.Where(x => x.Rate > 1000).ToList();
            return Ok(rate);
        }
        [HttpPost]
        public IActionResult Add(Product product)
        {
            return Ok(product);
        }
    }
}
