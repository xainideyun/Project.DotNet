using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sunxsh.Cors.IRespository;
using Sunxsh.Cors.IService;
using Sunxsh.Cors.Models;

namespace Sunxsh.Cors.Service
{
    public class MerchantService : BaseService<T_Merchant>, IMerchantService
    {
        public override void SetService()
        {
            Service = RespositoryContainer.Container.Resolve<IMerchantRepository>();
        }
    }
}
