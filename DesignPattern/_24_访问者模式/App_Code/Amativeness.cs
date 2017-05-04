using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_访问者模式.App_Code
{
    public class Amativeness : MyAction
    {
        public Amativeness()
        {
            Name = "恋爱";
        }
        public string Name { get; set; }
        public override void GetManConclution(Person person)
        {
            Console.WriteLine("{0}{1}时，凡事不懂也要装懂...", person.Name, Name);
        }

        public override void GetWomanConclution(Person person)
        {
            Console.WriteLine("{0}{1}时，遇事懂也装作不懂...", person.Name, Name);
        }
    }
}
