using System.Linq;

namespace _21_中介者模式.Demo
{
    public class Room : Mediator
    {
        private readonly string _name;

        public Room(string name)
        {
            _name = name;
        }
        public override void Send(string msg, User user)
        {
            var others = Users.Where(a => a != user);
            foreach (var other in others)
            {
                other.Notify($"来源--{_name}--" + msg);
            }
        }
    }
}