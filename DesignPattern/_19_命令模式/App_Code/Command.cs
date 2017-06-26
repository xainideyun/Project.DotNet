using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_命令模式.App_Code
{
    public abstract class Command
    {
        public string Name { get; set; }
        protected Executer executer;
        public Command(string name, Executer executer)
        {
            this.Name = name;
            this.executer = executer;
        }
        public abstract void Execute();
    }
}
