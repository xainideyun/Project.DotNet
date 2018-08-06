using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web;
using System.Web.Http;
using Newtonsoft.Json.Serialization;

namespace Sunxsh.Jdcat.Api.Configuration
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );


            // 更改JSON序列化时的媒体格式化器（属性名驼峰命名），默认：JsonMediaTypeFormatter
            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            // XML格式化器：XmlMediaTypeFormatter


        }
    }
}