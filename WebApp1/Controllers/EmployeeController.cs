using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.Internal;
using WebApp1.data;
using WebApp1.Model;

namespace WebApp1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly MyDbcontext myDbcontext;

        public EmployeeController(MyDbcontext myDbcontext)
        {
            this.myDbcontext = myDbcontext;
        }
        [HttpGet]
        public IActionResult Getdata()
        {
            var GetRecord = myDbcontext.Employee.ToList();
            return Ok(GetRecord);
        }
        [HttpPost]
        public IActionResult Postdata(Employee employee)
        {
            myDbcontext.Employee.Add(employee);
            myDbcontext.SaveChanges();
            return Ok(employee);
        }
        [HttpPut]
        [Route("{id}")]
        public IActionResult Putdata(Employee employee)
        {
            var putrecord = myDbcontext.Employee.Where(x => x.ID == employee.ID).FirstOrDefault();
            putrecord.EmployeName = employee.EmployeName;
            putrecord.Designation = employee.Designation;
            putrecord.Salary = employee.Salary;
            if (putrecord == null)
            {
                return NotFound();
            }
            myDbcontext.SaveChanges();
            return Ok(putrecord);
        }
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Deletedata(int id)
        {
            var deleterecord = myDbcontext.Employee.Where(x=>x.ID == id).FirstOrDefault();
            if (deleterecord == null)
            {
                return NotFound();
            }
            myDbcontext.Employee.Remove(deleterecord);

            myDbcontext.SaveChanges();
            
            return Ok(deleterecord);
        }
    }
}
