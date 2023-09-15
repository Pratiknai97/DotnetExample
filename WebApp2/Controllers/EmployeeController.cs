using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp2.data;
using WebApp2.Model;

namespace WebApp2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly Mydbcontext mydbcontext;

        public EmployeeController(Mydbcontext mydbcontext) 
        {
            this.mydbcontext = mydbcontext;
        }
        [HttpPost]
        public IActionResult postdata(Employee employee)
        {
           mydbcontext.employee.Add(employee);
            mydbcontext.SaveChanges();
            return Ok(employee);
        }
        [HttpPut]

        public IActionResult putdata(Employee employee)
        {
            var putrecord = mydbcontext.employee.Where(x=>x.Id == employee.Id).FirstOrDefault();
            if(putrecord == null)
            {
                return NotFound();
            }
            putrecord.Id = employee.Id;
            putrecord.EmployeName = employee.EmployeName;
            putrecord.Designation = employee.Designation;
            putrecord.Salary   = employee.Salary;
            mydbcontext.SaveChanges();
            return Ok(putrecord);
        }

    }
}
