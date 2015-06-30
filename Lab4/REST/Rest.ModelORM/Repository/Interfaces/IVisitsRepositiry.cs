﻿using Rest.ModelORM.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rest.ModelORM.Repository.IRepository
{
    public interface IVisitsRepositiry
    {
        void Add(Visit visit);
        List<Visit> GetVisitsByDateAndStatus(DateTime date, bool isFree);
    }
}