using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.App_Code
{
    public interface IMyDbContext
    {
        void Add(Entity entity);
        void Delete(string id);
        void Delete(Entity entity);
        void Update(Entity entity);
        string SearchAll();

    }
}
