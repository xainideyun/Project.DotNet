using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_访问者模式.App_Code
{
    public abstract class Person
    {
        public string Name { get; set; }
        public abstract void Active(MyAction action);
    }
}
