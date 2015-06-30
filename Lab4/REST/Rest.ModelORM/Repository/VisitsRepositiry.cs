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
    public class VisitsRepositiry : BaseDbContextRepository<Visit, RESTEntities>, IVisitsRepositiry
    {
        public List<Visit> GetVisitsByDateAndStatus(DateTime date, bool isFree)
        {
            return Items.Where(x => x.Date == date && x.IsFree == isFree).ToList();
        }

        public void BookVisit(int id , Patient patient)
        {
            var visit = Items.FirstOrDefault(x => x.id == id);

            visit.Patient.Name = patient.Name;
            visit.Patient.Surname = patient.Surname;
            visit.IsFree = false;
            Entities.SaveChanges();
        }
    }
}
