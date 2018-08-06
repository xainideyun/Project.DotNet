using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Sunxsh.Jdcat.Api.Data;

namespace Sunxsh.Jdcat.Api.Controller
{
    public class StudentController : ApiController
    {

        public IList<Student> Get()
        {
            return Student.Students;
        }

        public HttpResponseMessage Post([FromBody]Student student)
        {
            Student.Students.Add(student);
            return Request.CreateResponse(HttpStatusCode.OK, Student.Students);
        }

    }
}
