using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_访问者模式.App_Code
{
    public class Failing : MyAction
    {
        public Failing()
        {
            Name = "失败";
        }
        public string Name { get; set; }
        public override void GetManConclution(Person person)
        {
            Console.WriteLine("{0}{1}时，闷头喝酒，谁也劝不了...", person.Name, Name);
        }

        public override void GetWomanConclution(Person person)
        {
            Console.WriteLine("{0}{1}时，泪眼汪汪，谁也不用劝...", person.Name, Name);
        }
    }
}
