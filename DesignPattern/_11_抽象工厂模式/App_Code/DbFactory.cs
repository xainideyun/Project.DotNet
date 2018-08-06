using System;
using System.Configuration;
using System.Reflection;

namespace _11_抽象工厂模式
{
    public class DbFactory
    {
        private static string _dbSign;

        public static string DbSign => _dbSign ?? (_dbSign = ConfigurationManager.AppSettings["DbSign"]);
        private static readonly string AssemblyName;
        private static readonly string ClassName;

        static DbFactory()
        {
            var arr = DbSign.Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            AssemblyName = arr[0].Trim();
            ClassName = arr[1].Trim();
        }

        public static IFactory CreateFactory()
        {
            var factory = Assembly.Load(AssemblyName).CreateInstance(ClassName) as IFactory;
            return factory;
        }
    }
}