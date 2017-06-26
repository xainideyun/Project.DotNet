using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_命令模式.App_Code
{
    public class Executer
    {
        public void ExecPhone(string name)
        {
            Console.WriteLine($"{name}：我已经帮你处理完一个手机业务！");
        }
        public void ExecMarry(string name)
        {
            Console.WriteLine($"{name}：恭喜你们结婚了！");
        }
    }
}
