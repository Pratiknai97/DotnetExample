using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp3.Interface;

namespace WebApp3.Controllers
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
