using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using REST.Model.Entity;

namespace REST.Model.Repository.IRepository
{
    public interface IReviewsRepository
    {
        void Add(Reviews review);
    }
}
