using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Sunxsh.SmallProgram.Web.Models;

namespace Sunxsh.SmallProgram.Web.Controllers
{
    public class StudentController : ApiController
    {
        public List<Student> Students { get; set; } = new List<Student>
        {
            new Student{ Name = "孙小双", Age = 28, Code = "sunxsh"},
            new Student{ Name = "张三", Age = 33, Code = "zhangs"},
            new Student{ Name = "李四", Age = 67, Code = "lisi"}
        };
        public IEnumerable<Student> Get()
        {
            return Students;
        }
    }
}
