using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_职责链模式.App_Code
{
    public class TopManager : Manager
    {
        public TopManager(string name) : base(name)
        {
        }

        public override void ProcessingRequest(RequestType type, int num)
        {
            if (type == RequestType.Leave && num <= 20)
            {
                Console.WriteLine("{0}：{1} 数量{2} 批准！", _name, EnumHelper.GetDescription(type), num);
            }
            else if(type == RequestType.Raises && num <= 500)
            {
                Console.WriteLine("{0}：{1} 数量{2} 批准！", _name, EnumHelper.GetDescription(type), num);
            }
            else
            {
                Console.WriteLine("{0}：{1} 数量{2} 需要斟酌！", _name, EnumHelper.GetDescription(type), num);
            }
        }
    }
}
