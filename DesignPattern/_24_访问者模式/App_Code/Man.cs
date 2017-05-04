using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_访问者模式.App_Code
{
    public class Man : Person
    {
        public Man()
        {
            Name = "男人";
        }
        public override void Active(MyAction action)
        {
            action.GetManConclution(this);
        }
    }
}
