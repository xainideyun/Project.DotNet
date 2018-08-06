using System;
using _11_抽象工厂模式.Models;

namespace _11_抽象工厂模式.Class
{
    public class SqlServerUser : IUser
    {
        public void Insert(User user)
        {
            Console.WriteLine("sqlserver增加用户");
        }

        public void Update(User user)
        {
            Console.WriteLine("sqlserver修改用户");
        }

        public void Delete(User user)
        {
            Console.WriteLine("sqlserver删除用户");
        }

        public void Delete(string id)
        {
            Console.WriteLine("sqlserver删除用户");
        }
    }
}