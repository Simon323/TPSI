﻿using REST.Nancy.Models;
using REST.Nancy.Reporitories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace REST.Nancy.Reporitories
{
    public class ReviewRepository : IReviewRepository
    {
        public void Add(Reviews item)
        {
            StaticModel.ReviewsList.Add(item);
        }
    }
}