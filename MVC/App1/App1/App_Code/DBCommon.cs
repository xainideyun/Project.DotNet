using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App1.App_Code
{
    public class DbCommon : IMyDbContext
    {
        protected IMyDbContext context;
        public void Add(Entity entity)
        {
            context.Add(entity);
        }

        public void Delete(string id)
        {
            context.Delete(id);
        }

        public void Delete(Entity entity)
        {
            context.Delete(entity);
        }

        public void Update(Entity entity)
        {
            context.Update(entity);
        }

        public string SearchAll()
        {
            return context.SearchAll();
        }
    }
}