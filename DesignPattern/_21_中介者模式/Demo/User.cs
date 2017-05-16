using System;

namespace _21_中介者模式.Demo
{
    public class User
    {
        private readonly Mediator _mediator;

        public User(Mediator mediator, string name)
        {
            _mediator = mediator;
            Name = name;
        }
        public string Name { get; set; }
        public int Age { get; set; }

        public void Send(string msg)
        {
            _mediator.Send(msg, this);
        }

        public void Notify(string msg)
        {
            Console.WriteLine($"用户{Name}收到消息：{msg}");
        }
    }
}