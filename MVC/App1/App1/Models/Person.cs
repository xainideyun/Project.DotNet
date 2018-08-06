using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace App1.Models
{
    public class Person
    {
        [Compare("Age")]
        public string Name { get; set; }
        public int Age { get; set; }

    }
}