using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_享元模式.App_Code
{
    public class FlyweightFactory
    {
        private Dictionary<string, Flyweight> dic = new Dictionary<string, Flyweight>();
        public Flyweight GetFlyweight(string sign)
        {
            Flyweight obj;
            if (dic.ContainsKey(sign))
            {
                obj = dic[sign];
            }
            else
            {
                obj = new ShareFlyweight();
                dic.Add(sign, obj);
            }

            return obj;
        }
    }
}
