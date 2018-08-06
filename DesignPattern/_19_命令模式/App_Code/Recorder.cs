using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_命令模式.App_Code
{
    public class Recorder
    {
        private readonly IList<Command> _list = new List<Command>();
        public void SetOrder(Command command)
        {
            _list.Add(command);
        }
        public void CancleOrder(Command command)
        {
            _list.Remove(command);
            Console.WriteLine($"客户{command.Name}取消业务办理！");
        }
        public void Notify()
        {
            foreach (var item in _list)
            {
                item.Execute();
            }
        }
    }
}
