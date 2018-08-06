using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_命令模式.Code
{
    public class Gongbaojiding : Command
    {
        public Gongbaojiding(Chushi chushi) : base(chushi)
        {
        }

        public override void Execute()
        {
            chushi.ExecuteGongbaojiding();
        }
    }
}
