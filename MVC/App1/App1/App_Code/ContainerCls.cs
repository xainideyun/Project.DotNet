using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App1.App_Code
{
    public class ContainerCls
    {
        public static T CreateService<T>() where T : class
        {
            var type = typeof(T);
            var ctor = type.GetConstructor(new[] { typeof(IMyDbContext) });
            if (ctor == null) throw new Exception("不存在指定的构造函数...");
            var obj = ctor.Invoke(new object[] {new DbContext()});
            return (T)obj;
        }
    }
}