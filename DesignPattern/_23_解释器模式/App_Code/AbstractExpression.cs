using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_解释器模式.App_Code
{
    public abstract class AbstractExpression
    {
        public abstract void Handler(Context context);
    }
}
