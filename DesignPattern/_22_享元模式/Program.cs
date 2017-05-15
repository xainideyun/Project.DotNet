using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _22_享元模式.App_Code;
using _22_享元模式.Demo;

namespace _22_享元模式
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1

//            var factory = new FlyweightFactory();
//            var f1 = factory.GetFlyweight("x");
//            var f2 = factory.GetFlyweight("y");
//            var f3 = factory.GetFlyweight("z");
//            var f4 = new UnShareFlyweight();
//            var num = 10;
//            f1.Operation(--num);
//            f2.Operation(--num);
//            f3.Operation(--num);
//            f4.Operation(--num);

            #endregion

            #region 2

            var pf = new PersonFactory();
            pf.CreatePerson(PersonType.Doctor, "孙小双").Say();
            pf.CreatePerson(PersonType.Student, "万星辉").Say();
            pf.CreatePerson(PersonType.Teacher, "李娟娟").Say();
            pf.CreatePerson(PersonType.Doctor, "李怡然").Say();
            pf.CreatePerson(PersonType.Teacher, "鲁冰冰").Say();
            pf.CreatePerson(PersonType.Teacher, "尹晓畅").Say();

            #endregion
            Console.ReadKey();
        }
    }
}
