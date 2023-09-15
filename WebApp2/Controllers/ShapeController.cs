using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp2.Interface;

namespace WebApp2.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ShapeController : ControllerBase
    {
        private readonly IShape shape;

        public ShapeController(IShape shape)
        {
            this.shape = shape;
        }

       
        [HttpGet]
        public IActionResult getdata()
        {
            return Ok(shape.Draw());
        }
    }
}
