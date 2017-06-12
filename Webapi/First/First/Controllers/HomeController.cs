using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Http.Filters;
using First.Model;

namespace First.Controllers
{
    public class HomeController : ApiController
    {
        private readonly List<Student> _students = new List<Student>
        {
            new Student{Id = 1, Age = 29, Name = "孙小双"},
            new Student{Id = 2, Age = 27, Name = "万星辉"},
            new Student{Id = 3, Age = 30, Name = "杨欢"}
        };
        public IHttpActionResult Get()
        {
            //            return new List<string>
            //            {
            //                "万星辉", "孙小双"
            //            };
            

//            return Content(HttpStatusCode.OK, GlobalConfiguration.Configuration.Formatters.Select(formatter => formatter.ToString()).ToList(), new JsonMediaTypeFormatter());

//            return GlobalConfiguration.Configuration.Formatters.Select(formatter => formatter.ToString()).ToList();
//            return Ok(_students);
            return Content(HttpStatusCode.OK, _students, new JsonMediaTypeFormatter());
        }

        //        public string Get()
        //        {
        //            return "万星辉";
        //        }

        public Student Get(int id)
        {
            return _students.First(a => a.Id == id);
        }

        public Student Post(Student stu)
        {
            _students.Add(stu);
            stu.Id = _students.Count;
            return stu;
        }

    }
}
