using REST.ModelORM.EntityModel;
using REST.ModelORM.Repository.IRepository;
using REST.DBContext.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REST.ModelORM.Repository
{
    public class CommentsRepository : BaseDbContextRepository<Comment, RESTEntities>, ICommentsRepository
    {
    }
}
