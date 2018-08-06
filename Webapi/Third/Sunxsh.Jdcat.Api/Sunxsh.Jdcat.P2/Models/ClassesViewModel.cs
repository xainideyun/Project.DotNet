using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sunxsh.Jdcat.P2.Models
{
    public class ClassesViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Remark { get; set; }
        public ICollection<StudentViewModel> Collection { get; set; }
    }
}