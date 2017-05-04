using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_访问者模式.App_Code
{
    public class Woman : Person
    {
        public Woman()
        {
            Name = "女人";
        }
        public override void Active(MyAction action)
        {
            action.GetWomanConclution(this);
        }
    }
}
