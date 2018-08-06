using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace Sunxsh.Cors.Web.Models
{
    public class DadaModel
    {
        public string app_key { get; set; } = Util.UtilData.App_key;
        private string sign;
        public string signature
        {
            get
            {
                var strBuild = new StringBuilder();
                strBuild.Append(Util.UtilData.App_secret);
                strBuild.Append("app_key");
                strBuild.Append(app_key);
                strBuild.Append("body");
                strBuild.Append(body);
                strBuild.Append("format");
                strBuild.Append(format);
                strBuild.Append("source_id");
                strBuild.Append(source_id);
                strBuild.Append("timestamp");
                strBuild.Append(timestamp);
                strBuild.Append("v");
                strBuild.Append(v);
                strBuild.Append(Util.UtilData.App_secret);
                var result = Util.Util.GetMD5(strBuild.ToString());
                return result.ToUpper();
            }
        }
        public string timestamp { get; set; } = (DateTime.Now - Util.UtilData.StarTime).TotalMilliseconds.ToString();
        public string format { get; set; } = "json";
        public string v { get; set; } = "1.0";
        public string source_id { get; set; } = "73753";
        public string body { get; set; }
    }
}