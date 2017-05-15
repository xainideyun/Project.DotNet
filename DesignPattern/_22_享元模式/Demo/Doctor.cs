using System;

namespace _22_享元模式.Demo
{
    public sealed class Doctor : Person
    {
        public Doctor(string name) : base(name)
        {
            CardName = "医生";
        }

        public override void Say()
        {
            base.Say();
            Console.WriteLine("我经常在实验室里玩解剖游戏！");
            Console.WriteLine("----------------------------");
        }
    }
}