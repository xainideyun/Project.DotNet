using System;

namespace _22_享元模式.Demo
{
    public sealed class Student : Person
    {
        public override void Say()
        {
            base.Say();
            Console.WriteLine("我总是打别人家的孩子！");
            Console.WriteLine("----------------------------");
        }

        public Student(string name) : base(name)
        {
            CardName = "学生";
        }

    }
}