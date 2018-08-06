using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_命令模式.App_Code
{
    public class PhoneCommand : Command
    {
        public PhoneCommand(string name, Executer executer) : base(name, executer)
        {
        }

        public override void Execute()
        {
            Executer.ExecPhone(Name);
        }
    }
}
