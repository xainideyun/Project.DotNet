using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _21_中介者模式.App_Code;
using _21_中介者模式.Demo;

namespace _21_中介者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1
            
//            var mediator = new UnitedNation();
//            var china = new China(mediator);
//            var americal = new Amarical(mediator);
//            mediator.Country1 = china;
//            mediator.Country2 = americal;
//            china.Send("你好");
//            americal.Send("滚");

            #endregion

            #region 2

            var mediator = new Room("聊天室1");
            var users = new List<User>
            {
                new User(mediator, "孙小双"),
                new User(mediator, "万星辉"),
                new User(mediator, "李娟娟"),
                new User(mediator, "李怡然"),
            };
            mediator.AddUser(users.ToArray());
            users[0].Send("你们好吗");
            users[1].Send("我很好，谢谢你！");

            #endregion

            Console.ReadKey();
        }
    }
}
