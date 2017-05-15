using System;

namespace _22_享元模式.Demo
{
    public sealed class Teacher : Person
    {
        public override void Say()
        {
            base.Say();
            Console.WriteLine("不听话的孩子最讨厌了！");
            Console.WriteLine("----------------------------");
        }

        public Teacher(string name) : base(name)
        {
            CardName = "老师";
        }
    }
}