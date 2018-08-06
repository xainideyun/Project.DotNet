using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunxsh.Cors.Util
{
    public class UtilData
    {
        static UtilData()
        {
            App_key = ConfigurationManager.AppSettings["app_key"];
            App_secret = ConfigurationManager.AppSettings["app_secret"];
            App_url = ConfigurationManager.AppSettings["app_url"];
        }
        public static readonly DateTime StarTime = new DateTime(1970, 1, 1);
        public static readonly string App_key;
        public static readonly string App_secret;
        public static readonly string App_url;
    }
}
