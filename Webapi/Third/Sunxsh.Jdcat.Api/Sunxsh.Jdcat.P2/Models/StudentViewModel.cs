using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sunxsh.Jdcat.P2.Models
{
    public class StudentViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string UserName { get; set; }
        public int? Age { get; set; }
        public ClassesViewModel Class { get; set; }
        public AddressViewModel Address { get; set; }
    }
}