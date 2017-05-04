using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_访问者模式.App_Code
{
    public class Success : MyAction
    {
        public Success()
        {
            Name = "成功";
        }
        public string Name { get; set; }
        public override void GetManConclution(Person person)
        {
            Console.WriteLine("{0}{1}时，背后多半有一个伟大的女人...", person.Name, Name);
        }

        public override void GetWomanConclution(Person person)
        {
            Console.WriteLine("{0}{1}时，背后大多有一个不成功的男人...", person.Name, Name);
        }
    }
}
