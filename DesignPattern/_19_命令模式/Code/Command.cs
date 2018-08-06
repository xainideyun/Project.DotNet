using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_命令模式.Code
{
    public abstract class Command
    {
        protected Chushi chushi;

        protected Command(Chushi chushi)
        {
            this.chushi = chushi;
        }

        public abstract void Execute();
    }
}
