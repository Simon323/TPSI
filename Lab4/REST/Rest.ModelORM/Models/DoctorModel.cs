using REST.ModelORM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REST.ModelORM.Model
{
    public class DoctorModel
    {
        public DoctorModel()
        {
            Opinion = new List<CommentModel>();
            Visits = new List<VisitModel>();
        }
        public int id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public string Specialization { get; set; }
        public List<CommentModel> Opinion { get; set; }
        public List<VisitModel> Visits { get; set; }
    }
}
