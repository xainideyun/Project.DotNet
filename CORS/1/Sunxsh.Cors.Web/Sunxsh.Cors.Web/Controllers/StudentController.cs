using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Sunxsh.Cors.Web.Models;

namespace Sunxsh.Cors.Web.Controllers
{
    public class StudentController : ApiController
    {
        public IList<Student> Students { get; set; } =
            new[]
        {
            new Student{Id = 1, Age = 29, Name = "孙小双", Salary = 0},
            new Student{Id = 2, Age = 27, Name = "代书畅", Salary = 5020 }
        };
        
        public IEnumerable<Student> Get()
        {
            return Students;
        }
        
        public Student Get(int id)
        {
            return Students.FirstOrDefault(a => a.Id == id);
        }
        
        public void Post([FromBody]Student stu)
        {

        }
        
        public void Put([FromUri]int id, [FromBody]Student stu)
        {

        }
        
        public void Delete(int id)
        {
        }
    }
}
