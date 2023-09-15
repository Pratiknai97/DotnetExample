using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp2.data;
using WebApp2.Interface;

namespace WebApp2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SizeController : ControllerBase
    {
        private readonly ISize size;

        public SizeController(ISize size)
        {
            this.size = size;
        }
        [HttpGet]
        public IActionResult Getdata() 
        {
            return Ok(size.Width());
        }
    }
}
