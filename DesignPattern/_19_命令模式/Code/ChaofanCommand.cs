using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_命令模式.Code
{
    class ChaofanCommand : Command
    {
        public ChaofanCommand(Chushi chushi) : base(chushi)
        {
        }

        public override void Execute()
        {
            chushi.ExecuteChaofan();
        }
    }
}
