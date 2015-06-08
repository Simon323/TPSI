using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver.Linq;
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

        public void Add(Visits visit)
        {
            ctx.Collection.Save(visit);
        }

        public List<Visits> GetVisitsByDateAndStatus(DateTime date, bool isFree)
        {
            return ctx.Collection.AsQueryable().ToList().Where(x => x.Date == date && x.IsFree == isFree).ToList();
        }

        public void BookVisit(string idString , Patient patient)
        {
            var id = new ObjectId(idString);
            var visit = ctx.Collection.AsQueryable().FirstOrDefault(x => x.Id == id);

            visit.Patient.Name = patient.Name;
            visit.Patient.Surname = patient.Surname;
            visit.IsFree = false;

            ctx.Collection.Save(visit);
        }
    }
}
