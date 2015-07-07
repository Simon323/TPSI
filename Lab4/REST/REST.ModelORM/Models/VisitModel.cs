using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REST.ModelORM.Models
{
    public class VisitModel
    {
        public int id { get; set; }
        public System.DateTime Date { get; set; }
        public bool IsFree { get; set; }
        public int PatientId { get; set; }
    }
}
