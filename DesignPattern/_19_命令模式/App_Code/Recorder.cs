using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_命令模式.App_Code
{
    public class Recorder
    {
        private IList<Command> list = new List<Command>();
        public void SetOrder(Command command)
        {
            list.Add(command);
        }
        public void CancleOrder(Command command)
        {
            list.Remove(command);
            Console.WriteLine($"客户{command.Name}取消业务办理！");
        }
        public void Notify()
        {
            foreach (var item in list)
            {
                item.Execute();
            }
        }
    }
}
