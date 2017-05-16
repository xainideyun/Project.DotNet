using System.Collections.Generic;

namespace _21_中介者模式.Demo
{
    public abstract class Mediator
    {
        protected List<User> Users = new List<User>();
        
        public abstract void Send(string msg, User user);

        public void AddUser(params User[] user)
        {
            Users.AddRange(user);
        }
    }
}