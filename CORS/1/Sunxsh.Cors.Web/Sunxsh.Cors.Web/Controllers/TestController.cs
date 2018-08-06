using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using Sunxsh.Cors.Web.Models;

namespace Sunxsh.Cors.Web.Controllers
{
    public class TestController : ApiController
    {
        public IHttpActionResult Post()
        {
            Send();
            return Ok();
        }

        private async void Send()
        {
            using (var hc = new HttpClient())
            {
                var order = new Order { order_id = DateTime.Now.ToString("yyyyMMddHHmmss") };
                var dada = new DadaModel { body = JsonConvert.SerializeObject(order) };
                var result = await hc.PostAsJsonAsync(Util.UtilData.App_url, JsonConvert.SerializeObject(dada));
                result.EnsureSuccessStatusCode();

            }
        }
    }
}
