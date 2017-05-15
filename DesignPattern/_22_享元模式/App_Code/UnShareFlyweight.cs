using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_享元模式.App_Code
{
    public class UnShareFlyweight : Flyweight
    {
        public override void Operation(int mode)
        {
            Console.WriteLine("不可以共享的实例：" + mode);
        }
    }
}
