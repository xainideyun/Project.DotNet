using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _23_解释器模式.App_Code;

namespace _23_解释器模式
{
    class Program
    {
        static void Main(string[] args)
        {
            //            var context = new Context { Input = "420984198805050437" };
            var context = new Context { Input = "sunxsaljj@163.com" };
            var list = new List<AbstractExpression> { new EmailExpression(), new IdCardExpression() };
            foreach (var item in list)
            {
                item.Handler(context);
                Console.WriteLine(context.Output);
            }
            

            Console.ReadKey();
        }
    }
}
