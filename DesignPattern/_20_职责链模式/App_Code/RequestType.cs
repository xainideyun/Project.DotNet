using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_职责链模式.App_Code
{
    public enum RequestType
    {
        [Description("请假")]
        Leave,
        [Description("加薪")]
        Raises
    }
}
