using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp1.Interface;

namespace WebApp1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShapeController : ControllerBase
    {
        private readonly IShape shape;

        public ShapeController(IShape shape )
        {
            this.shape = shape;
        }
        [HttpGet]
        public IActionResult Getdata() 
        {
            return Ok(shape.Drow());
        }
    }
}
