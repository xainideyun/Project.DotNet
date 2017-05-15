using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _23_解释器模式.App_Code
{
    public class IdCardExpression : AbstractExpression
    {
        private static readonly string _exp = @"^[1-9]\d{5}[1-9]\d{3}((0\d)|(1[0-2]))(([0|1|2]\d)|3[0-1])\d{3}([0-9]|X)$";
        public override void Handler(Context context)
        {
            var reg = new Regex(_exp);
            var result = reg.IsMatch(context.Input);
            context.Output = result ? "身份证正确..." : "身份证错误...";
        }
    }
}
