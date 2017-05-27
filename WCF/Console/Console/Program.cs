using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using Services;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(User), new Uri("http://localhost:8801/UserService")))
            {
                host.AddServiceEndpoint(typeof(IUser), new BasicHttpBinding(), "");
                var smb = new ServiceMetadataBehavior { HttpGetEnabled = true };
                host.Description.Behaviors.Add(smb);
                host.Open();
                System.Console.WriteLine("服务已经启动...");
                System.Console.ReadKey();
            }
        }
    }
}
