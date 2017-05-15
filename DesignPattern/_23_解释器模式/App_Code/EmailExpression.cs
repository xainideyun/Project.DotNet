using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _23_解释器模式.App_Code
{
    public class EmailExpression : AbstractExpression
    {
        private static readonly string _exp = @"^(\w)+(\.\w+)*@(\w)+((\.\w+)+)$";
        public override void Handler(Context context)
        {
            var reg = new Regex(_exp);
            var result = reg.IsMatch(context.Input);
            context.Output = result ? "邮件正确..." : "邮件错误...";
        }
    }
}
