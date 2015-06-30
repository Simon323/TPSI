using Rest.ModelORM.EntityModel;
using Rest.ModelORM.Repository.IRepository;
using REST.DBContext.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rest.ModelORM.Repository
{
    public class CommentsRepository : BaseDbContextRepository<Comment, RESTEntities>, ICommentsRepository
    {
    }
}
