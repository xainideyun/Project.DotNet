using System;
using _11_抽象工厂模式.Models;

namespace _11_抽象工厂模式.Class
{
    public class OracleUser : IUser
    {
        public void Insert(User user)
        {
            Console.WriteLine("Oracle增加用户");
        }

        public void Update(User user)
        {
            Console.WriteLine("Oracle修改用户");
        }

        public void Delete(User user)
        {
            Console.WriteLine("Oracle删除用户");
        }

        public void Delete(string id)
        {
            Console.WriteLine("Oracle删除用户");
        }
    }
}