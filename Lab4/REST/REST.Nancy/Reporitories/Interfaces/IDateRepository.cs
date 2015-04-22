using REST.Nancy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace REST.Nancy.Reporitories.Interfaces
{
    public interface IDateRepository
    {
        void Add(Dates item);
    }
}