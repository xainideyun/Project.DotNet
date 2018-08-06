using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sunxsh.Console.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            //            M1();

            //            M4();
            //            System.Console.WriteLine("主线程在执行");

            M5();

            System.Console.ReadKey();
        }

        private static void M1()
        {
            var num = 10;
            for (var i = 0; i < num; i++)
            {
                var i1 = i;
                System.Threading.Tasks.Task.Run(() =>
                {
                    System.Console.WriteLine("打印i：{0}", i1);
                });
            }
            Thread.Sleep(10);
            System.Console.WriteLine("我是主线程...");

        }

        static Task<string> M2()
        {
            return System.Threading.Tasks.Task.Run(() => M3());
        }

        static string M3()
        {
            Thread.Sleep(300);
            return "孙小双 + 李怡然 + 李娟娟 + 万星辉";
        }

        static async void M4()
        {
            var name = await M2();
            System.Console.WriteLine(name);
        }

        static async void M5()
        {
            using (var client = new HttpClient())
            {
                var msg = await client.PostAsJsonAsync("http://localhost:6001", new {name = "孙小双"});
                var content = await msg.Content.ReadAsStringAsync();
                System.Console.WriteLine(content);
            }
        }
    }
}
