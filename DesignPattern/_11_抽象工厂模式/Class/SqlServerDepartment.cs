using System;
using _11_抽象工厂模式.Models;

namespace _11_抽象工厂模式.Class
{
    public class OracleDepartment : IDepartment
    {
        public void Insert(Department user)
        {
            Console.WriteLine("Oracle增加部门");
        }

        public void Update(Department user)
        {
            Console.WriteLine("Oracle修改部门");
        }

        public void Delete(Department user)
        {
            Console.WriteLine("Oracle删除部门");
        }

        public void Delete(string id)
        {
            Console.WriteLine("Oracle删除部门");
        }

        public string GetCode(string id)
        {
            Console.WriteLine("Oracle根据id获取部门编码");
            return "code";
        }
    }
}