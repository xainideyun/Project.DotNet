using System;
using _11_抽象工厂模式.Models;

namespace _11_抽象工厂模式.Class
{
    public class SqlServerDepartment : IDepartment
    {
        public void Insert(Department user)
        {
            Console.WriteLine("sqlserver增加部门");
        }

        public void Update(Department user)
        {
            Console.WriteLine("sqlserver修改部门");
        }

        public void Delete(Department user)
        {
            Console.WriteLine("sqlserver删除部门");
        }

        public void Delete(string id)
        {
            Console.WriteLine("sqlserver删除部门");
        }

        public string GetCode(string id)
        {
            Console.WriteLine("sqlserver根据id获取部门编码");
            return "code";
        }
    }
}