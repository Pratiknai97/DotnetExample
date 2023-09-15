using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp2.data;
using WebApp2.Model;

namespace WebApp2.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly Mydbcontext mydbcontext;

        public ProductController(Mydbcontext mydbcontext ) {
            this.mydbcontext = mydbcontext;
        }

        [HttpGet]
        public IActionResult GetData()
        {
            List <Product> products = new List<Product>();
            products.Add(new Product { ID = 1, PName = "jvnsdnkvs", Rate=3443434 });
            products.Add(new Product { ID = 2, PName = "vkmkvmmvms", Rate = 22222000 });
            products.Add(new Product { ID = 3, PName = "mvmslvmsv", Rate = 3133131 });

            return Ok(products);
        }
        [HttpGet]

        public IActionResult getDataa() 
        { 
           // Mydbcontext mydbcontext = new Mydbcontext();
            var record = mydbcontext.product.ToList();
            return Ok(record);

        }
        [HttpPost]
        public IActionResult PostData(Product product)
        {
            mydbcontext.product.Add(product);
            mydbcontext.SaveChanges();
            return Ok(product);
        }
        [HttpPut]
        public IActionResult PutData(Product product)
        {
            var putrecord = mydbcontext.product.Where(x=>x.ID== product.ID).FirstOrDefault();
            putrecord.PName = product.PName;
            putrecord.Rate = product.Rate;
            if(putrecord == null)
            {
                return NotFound();
            }
            return Ok(putrecord);
        }
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Deletedata(Product product)
        {
            var deleterecord = mydbcontext.product.Where(x=>x.ID == product.ID).FirstOrDefault();       
            if(deleterecord == null)
            {
                return NotFound();
            }
            mydbcontext.product.Remove(deleterecord);
            mydbcontext.SaveChanges();
            return Ok(deleterecord);
        }
        [HttpGet]
        [Route("id")]
        public IActionResult Getdata(int id)
        {
            var GetById = mydbcontext.product.Where(x => x.ID == id).FirstOrDefault();
            if(GetById == null)
            {
                return NotFound();
            }
            return Ok(GetById);
        }
    }
}
