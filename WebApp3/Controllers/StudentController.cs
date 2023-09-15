using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp3.Data;
using WebApp3.Model;

namespace WebApp3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly MyDbContext myDbContext;

        public StudentController(MyDbContext myDbContext) 
        {
            this.myDbContext = myDbContext;
        }
        [HttpGet]

        public IActionResult Getdata()
        {

            // MyDbcontext myDbcontext = new MyDbcontext();
            var resultid = myDbContext.Student.ToList();
            if (resultid == null)
            {
                return Ok(resultid);
            }
            return Ok(resultid);
        }
        //[HttpPost]
        //public IActionResult Postdata(Student students)
        //{
        //    myDbContext.student.Add(students);
        //    myDbContext.SaveChanges();
        //    return Ok(students);
        //}

        [HttpPut]
       public IActionResult Putdata(Student student)
        {
            var putdata = myDbContext.Student.Where(x=>x.ID == student.ID).FirstOrDefault();
            if (putdata == null)
            {
                return Ok(putdata);
            }
            putdata.SName = student.SName;
            putdata.Semister =  student.Semister;
            putdata.Hobby = student.Hobby;
            myDbContext.SaveChanges();
            return Ok(putdata);
        }
        [HttpDelete]
        [Route("{id}")]

        public IActionResult Delete(int id)
        {
            var Deletedata = myDbContext.Student.Where(x=>x.ID ==id).FirstOrDefault();
            if(Deletedata == null)
            {
                return NotFound(Deletedata);
            }
            myDbContext.Student.Remove(Deletedata);
            myDbContext.SaveChanges();
            return Ok(Deletedata);
        }
    }
}
