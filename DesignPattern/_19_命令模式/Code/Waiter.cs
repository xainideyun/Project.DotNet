using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_命令模式.Code
{
    public class Waiter
    {
        private IList<Command> _list = new List<Command>();

        public void SetOrder(Command command)
        {
            _list.Add(command);
        }

        public void DelOrder(Command command)
        {
            _list.Remove(command);
        }

        public void Notify()
        {
            if (_list.Count == 0) return;
            foreach (var command in _list)
            {
                command.Execute();
            }
        }
    }
}
