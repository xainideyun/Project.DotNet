using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Sunxsh.Cors.IService;
using Sunxsh.Cors.Service;

namespace Sunxsh.Cors.ServiceContainer
{
    /// <summary>
    /// IOC容器
    /// </summary>
    public class Container
    {
        private static IContainer _container;
        public static T Resolve<T>()
        {
            try
            {
                if (_container == null)
                {
                    Initialise();
                }
            }
            catch (Exception e)
            {
                throw new Exception("IOC实例化出错！", e);
            }
            return _container.Resolve<T>();
        }

        private static void Initialise()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<UserService>().As<IUserService>().InstancePerLifetimeScope();
            builder.RegisterType<MerchantService>().As<IMerchantService>().InstancePerLifetimeScope();
            _container = builder.Build();
        }
    }
}
