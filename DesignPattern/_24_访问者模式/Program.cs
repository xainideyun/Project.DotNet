using _24_访问者模式.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_访问者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjStructure obj = new ObjStructure();
            obj.Attach(new Man());
            obj.Attach(new Woman());
            obj.Action(new Success());
            obj.Action(new Failing());
            obj.Action(new Amativeness());

            Console.Read();
        }
    }
}
