using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App1.App_Code
{
    public class DbService : DbCommon
    {
        public DbService(IMyDbContext context)
        {
            this.context = context;
        }

    }
}