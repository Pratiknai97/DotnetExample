using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp1.data;
using WebApp1.Model;

namespace WebApp1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        
        public IActionResult Getdata()
        {
            
            MyDbcontext myDbcontext = new MyDbcontext();
            var resultid = myDbcontext.Student.ToList();
            //foreach(var result in resultid)
            //{
            //    return Ok(result);
            //}
            return Ok(resultid);
        }
    }
}
