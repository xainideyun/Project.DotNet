using System;

namespace _22_享元模式.Demo
{
    public abstract class Person
    {
        protected Person(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public virtual string CardName { get; set; }

        public virtual void Say()
        {
            Console.WriteLine("我叫{0}，是一名{1}...", Name, CardName);
        }
    }
}