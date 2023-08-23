using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using WebApp1.data;
using WebApp1.Model;

namespace WebApp1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly MyDbcontext myDbcontext;

        //private MyDbcontext myDbcontext = new MyDbcontext();
        public StudentController(MyDbcontext myDbcontext)
        {
            this.myDbcontext = myDbcontext;
        }
        [HttpGet]

        public IActionResult Getdata()
        {

            // MyDbcontext myDbcontext = new MyDbcontext();
            var resultid = myDbcontext.Student.ToList();
            //foreach(var result in resultid)
            //{
            //    return Ok(result);
            //}
            return Ok(resultid);
        }
        [HttpPost]
        public IActionResult Postdata(Student student)
        {
            //MyDbcontext myDbcontext= new MyDbcontext();
            //Student s3 = new Student();
            // s3.SName = student.SName;
            // s3.Semister = student.Semister;
            // s3.Hobby = student.Hobby;
            myDbcontext.Student.Add(student);
            myDbcontext.SaveChanges();
            return Ok(student);

        }
        [HttpPut]
        public IActionResult EditStudent(Student student)
        {
            var data = myDbcontext.Student.Where(x => x.ID == student.ID).FirstOrDefault();
            if (data == null)
            {
                return NotFound();
            }
            data.SName = student.SName;
            data.Semister = student.Semister;
            data.Hobby = student.Hobby;
            myDbcontext.SaveChanges();
            return Ok(student);
        }
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            var deletedata = myDbcontext.Student.Where(x=>x.ID== id).FirstOrDefault();
            if (deletedata == null)
            {
                return NotFound();
            }
            myDbcontext.Student.Remove(deletedata);
            myDbcontext.SaveChanges();
            return Ok(deletedata);
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            var FindStudent = myDbcontext.Student.Where(x=>x.ID == id).FirstOrDefault();
            if(FindStudent == null)
            {
                return NotFound();
            }
            return Ok(FindStudent);
        }
    }
}
