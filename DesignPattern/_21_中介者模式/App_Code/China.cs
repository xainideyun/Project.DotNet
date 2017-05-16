using System;

namespace _21_中介者模式.App_Code
{
    public class China : Country
    {
        public China(Mediator mediator) : base(mediator)
        {
        }

        public override void Notify(string msg)
        {
            Console.WriteLine("中国收到消息： " + msg);
        }
    }
}