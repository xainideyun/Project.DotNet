using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _11_抽象工厂模式.Models;

namespace _11_抽象工厂模式
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = DbFactory.CreateFactory();
            var user = factory.GetUser();
            user.Insert(new User());
            user.Delete(new User());

            Console.Read();
        }
    }
}
