using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sunxsh.Webapi.Portal.Models
{
    public class StudentViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> Age { get; set; }
        public int ClassId { get; set; }
    }
}