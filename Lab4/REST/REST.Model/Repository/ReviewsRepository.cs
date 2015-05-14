using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver.Linq;
using REST.Model.Entity;
using REST.Model.Repository.IRepository;

namespace REST.Model.Repository
{
    public class ReviewsRepository : IReviewsRepository
    {
        private DbContext<Reviews> ctx;

        public ReviewsRepository()
        {
            ctx = new DbContext<Reviews>();
        }
    }
}
