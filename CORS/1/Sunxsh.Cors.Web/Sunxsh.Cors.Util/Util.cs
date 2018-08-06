using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Sunxsh.Cors.Util
{
    public static class Util
    {
        public static string GetMD5(string msg)
        {
            var md5 = new MD5CryptoServiceProvider();
            var data = Encoding.Unicode.GetBytes(msg);
            var byteString = md5.ComputeHash(data);
            var result = byteString.Aggregate(string.Empty, (current, c) => current + c.ToString("x"));
            return result;
        }
    }
}
