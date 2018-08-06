using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sunxsh.Jdcat.Api.Data
{
    public class Student
    {
        public static IList<Student> Students = new List<Student>
        {
            new Student{ Id = 1, Name = "孙小双", Code = "sunxiaoshuang", UserName = "Sunxsh"},
            new Student{ Id = 2, Name = "李怡然", Code = "liyiran", UserName = "Liyr"},
            new Student{ Id = 3, Name = "李娟娟", Code = "lijuanjuan", UserName = "Lijj"},
        };

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string UserName { get; set; }
    }
}