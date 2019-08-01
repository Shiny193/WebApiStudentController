using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Asswebapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        static public List<Student> Students = new List<Student>
               { new Student{Id="B150486", Division="ECE", FirstName="Harshini", LastNmae="Solanki", Grade="7.89"},
            new Student{Id="B150517", Division="ECE", FirstName="Supriya", LastNmae="Atyam", Grade="8.19"},
             new Student{Id="B150502", Division="CSE", FirstName="reethika", LastNmae="Vanaparthy", Grade="8.72"},
              new Student{Id="B150834", Division="EEE", FirstName="Poojitha", LastNmae="Vanukuru", Grade="7.89" } };
        // GET api/values
        [HttpGet]
        public List<Student> Get()
        {
         return Students; 
        }

        // GET api/values/5
        //[HttpGet("{id}")]
        //public ActionResult<string> Get(int id)
        //{
        //    return "value";
        //}

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Student newentry)
        {
            Students.Add(newentry);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] Student value)
        {
            var query = Students.Where(e => e.Id == id);
            foreach(Student e in query)
            {
                e.Division = value.Division;
                e.Grade = value.Grade;
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            Students.Remove(Students.FirstOrDefault(e => e.Id == id));
        }
    }
}
