using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Sunxsh.Cors.IService;
using Sunxsh.Cors.Models;

namespace Sunxsh.Cors.Web.Controllers
{
    public class UserController : ApiBaseController<IUserService>
    {
        // GET: api/User
        public IHttpActionResult Get()
        {
            return Json(Service.Get());
        }

        // GET: api/User/5
        public IHttpActionResult Get(int id)
        {
            return Json(Service.Get(id));
        }

        // POST: api/User
        public IHttpActionResult Post([FromBody]T_User entity)
        {
            Service.Add(entity);
            Service.SaveChanges();
            return Json(entity);
        }

        // PUT: api/User/5
        public IHttpActionResult Put([FromUri]int id, [FromBody]T_User entity)
        {
            Service.Update(entity);
            Service.SaveChanges();
            return Json(entity);
        }

        // DELETE: api/User/5
        public IHttpActionResult Delete(int id)
        {
            Service.Delete(id);
            Service.SaveChanges();
            return Ok();
        }
    }
}
