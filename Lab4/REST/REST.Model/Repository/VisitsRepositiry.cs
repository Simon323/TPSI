using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using REST.Model.Entity;
using REST.Model.Repository.IRepository;

namespace REST.Model.Repository
{
    public class VisitsRepositiry : IVisitsRepositiry
    {
        private DbContext<Visits> ctx;

        public VisitsRepositiry()
        {
            ctx = new DbContext<Visits>();
        }
    }
}
