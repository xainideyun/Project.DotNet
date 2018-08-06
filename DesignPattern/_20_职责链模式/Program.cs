using _20_职责链模式.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_职责链模式
{
    class Program
    {
        static void Main(string[] args)
        {
            var common = new CommonManager("欧阳新民");
            var majoy = new MajorManager("杨多青");
            var top = new TopManager("侯玉杰");
            common.SetSuperior(majoy);
            majoy.SetSuperior(top);


            common.ProcessingRequest(RequestType.Leave, 5);
            common.ProcessingRequest(RequestType.Leave, 1);
            common.ProcessingRequest(RequestType.Leave, 66);
            common.ProcessingRequest(RequestType.Leave, 17);
            common.ProcessingRequest(RequestType.Raises, 678);
            common.ProcessingRequest(RequestType.Raises, 300);

            Console.ReadKey();
        }
    }
}
