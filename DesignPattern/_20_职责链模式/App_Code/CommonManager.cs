using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_职责链模式.App_Code
{
    public class CommonManager : Manager
    {
        public CommonManager(string name) : base(name)
        {
        }

        public override void ProcessingRequest(RequestType type, int num)
        {
            if (type == RequestType.Leave && num <= 2)
            {
                Console.WriteLine("{0}：{1} 数量{2} 批准！", _name, EnumHelper.GetDescription(type), num);
                return;
            }
            else
            {
                if(_superior != null)
                {
                    _superior.ProcessingRequest(type, num);
                    return;
                }
            }
            Console.WriteLine("请求没有设置处理人...");
        }
    }
}
