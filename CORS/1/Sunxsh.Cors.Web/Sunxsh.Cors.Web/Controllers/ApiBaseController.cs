using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Sunxsh.Cors.IService;

namespace Sunxsh.Cors.Web.Controllers
{
    public class ApiBaseController<T> : ApiController
    {
        private T _service;
        public T Service {
            get
            {
                if (_service == null)
                {
                    _service = ServiceContainer.Container.Resolve<T>();
                }
                return _service;
            }
        }
    }
}
