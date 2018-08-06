using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Sunxsh.Cors.Models;

namespace Sunxsh.Cors.Respository
{
    public class DbContextFactory
    {
        /// <summary>
        /// 创建EF上下文对象，已存在则直接取，不存在就创建，保证线程内唯一
        /// </summary>
        /// <returns></returns>
        public static DbContext Create()
        {
            var dbContext = CallContext.GetData("DbContext");
            if (dbContext == null)
            {
                dbContext = new JiandancatEntities();
                CallContext.SetData("DbContext", dbContext);
            }
            return dbContext as DbContext;
        }
    }
}
