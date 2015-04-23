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

            reviewRepository.Add(new Reviews
            {
                id = 1,
                idDoctor = 1,
                Description = "Jest wspaniały najlepszy jakiego znam"
                
            });

            reviewRepository.Add(new Reviews
            {
                id = 2,
                idDoctor = 5,
                Description = "Bardzo przyjemna osoba"

            });

            reviewRepository.Add(new Reviews
            {
                id = 3,
                idDoctor = 5,
                Description = "Polecam na przyszłość"

            });

            reviewRepository.Add(new Reviews
            {
                id = 4,
                idDoctor = 2,
                Description = "Profesionalista w swoim zawodzie"

            });

            reviewRepository.Add(new Reviews
            {
                id = 5,
                idDoctor = 1,
                Description = "Zna sie na rzeczy"

            });

            reviewRepository.Add(new Reviews
            {
                id = 6,
                idDoctor = 3,
                Description = "Fachowa szyba pomoc"

            });

            reviewRepository.Add(new Reviews
            {
                id = 7,
                idDoctor = 1,
                Description = "Gorąco polecam"

            });

            reviewRepository.Add(new Reviews
            {
                id = 8,
                idDoctor = 4,
                Description = "Bardzo tani"

            });

            reviewRepository.Add(new Reviews
            {
                id = 9,
                idDoctor = 4,
                Description = "Fachowe porady"

            });

            reviewRepository.Add(new Reviews
            {
                id = 10,
                idDoctor = 1,
                Description = "Polecam na przyszłość"

            });

            reviewRepository.Add(new Reviews
            {
                id = 11,
                idDoctor = 3,
                Description = "Miły"

            });

            reviewRepository.Add(new Reviews
            {
                id = 12,
                idDoctor = 3,
                Description = "Jest ok"

            });

            reviewRepository.Add(new Reviews
            {
                id = 13,
                idDoctor = 5,
                Description = "Godna polecenia"

            });

        }

        public static int GetNewReviewId()
        {
            int id = 0;

            foreach (var doctor in StaticModel.DoctorsList)
            {
                foreach (var opinion in doctor.Reviews)
                {
                    if (opinion.id > id)
                        id = opinion.id;
                }
            }

            id++;

            return id;
        }
    }
}