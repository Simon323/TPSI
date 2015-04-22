using REST.Nancy.Models;
using REST.Nancy.Reporitories;
using REST.Nancy.Reporitories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace REST.Nancy.Helpers
{
    public class ReviewHelper
    {
        public static void FillReviewsList()
        {
            IReviewRepository reviewRepository = new ReviewRepository();

            Reviews reviews = new Reviews
            {
                id = 1,
                idDoctor = 1,
                Description = "jest wspaniały najlepszy jakiego znam"
                
            };

            reviewRepository.Add(reviews);
        }
    }
}