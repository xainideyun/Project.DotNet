using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App1.App_Code
{
    public class DbContext : IMyDbContext
    {
        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Entity entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Entity entity)
        {
            throw new NotImplementedException();
        }

        public string SearchAll()
        {
            return "你在哪里";
        }

        public void Add(Entity entity)
        {
            throw new NotImplementedException();
        }
    }
}