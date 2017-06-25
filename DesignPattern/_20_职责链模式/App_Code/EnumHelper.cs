using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _20_职责链模式.App_Code
{
    public class EnumHelper
    {
        public static string GetDescription<T>(T request)
        {
            var type = request.GetType();
            var info = type.GetField(request.ToString());
            if (info == null) return null;
            var da = info.GetCustomAttribute<DescriptionAttribute>();
            if (da == null) return null;
            return da.Description;
        }
    }
}
