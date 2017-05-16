using System;

namespace _21_中介者模式.App_Code
{
    public class Amarical : Country
    {
        public Amarical(Mediator mediator) : base(mediator)
        {
        }

        public override void Notify(string msg)
        {
            Console.WriteLine("美国收到消息： " + msg);
        }
    }
}