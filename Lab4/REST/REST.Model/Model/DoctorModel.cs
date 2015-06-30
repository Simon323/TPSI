using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REST.Model.Model
{
    public class DoctorModel
    {
        public DoctorModel()
        {
            Opinion = new List<string>();
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<string> Opinion { get; set; }
    }
}
