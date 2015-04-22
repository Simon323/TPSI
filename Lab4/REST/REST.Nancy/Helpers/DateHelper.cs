using REST.Nancy.Models;
using REST.Nancy.Reporitories.Interfaces;
using REST.Nancy.Routes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace REST.Nancy.Helpers
{
    public class DateHelper
    {
        public static void FillDateList()
        {
            IDateRepository dateRepository = new DateRepository();

            dateRepository.Add(new Dates
            {
                id = 1,
                idDoctor = 1,
                Date = new DateTime(2015, 1, 18)
            });

            dateRepository.Add(new Dates
            {
                id = 2,
                idDoctor = 2,
                Date = new DateTime(2015, 2, 18)
            });

            dateRepository.Add(new Dates
            {
                id = 3,
                idDoctor = 4,
                Date = new DateTime(2015, 3, 10)
            });

            dateRepository.Add(new Dates
            {
                id = 4,
                idDoctor = 3,
                Date = new DateTime(2015, 2, 12)
            });

            dateRepository.Add(new Dates
            {
                id = 5,
                idDoctor = 5,
                Date = new DateTime(2015, 4, 11)
            });

            dateRepository.Add(new Dates
            {
                id = 6,
                idDoctor = 5,
                Date = new DateTime(2015, 3, 14)
            });

            dateRepository.Add(new Dates
            {
                id = 7,
                idDoctor = 1,
                Date = new DateTime(2015, 4, 23)
            });

            dateRepository.Add(new Dates
            {
                id = 8,
                idDoctor = 3,
                Date = new DateTime(2015, 1, 12)
            });

            dateRepository.Add(new Dates
            {
                id = 9,
                idDoctor = 2,
                Date = new DateTime(2015, 2, 11)
            });

            dateRepository.Add(new Dates
            {
                id = 10,
                idDoctor = 5,
                Date = new DateTime(2015, 1, 16)
            });

            dateRepository.Add(new Dates
            {
                id = 11,
                idDoctor = 5,
                Date = new DateTime(2015, 2, 17)
            });

            dateRepository.Add(new Dates
            {
                id = 12,
                idDoctor = 4,
                Date = new DateTime(2015, 2, 14)
            });

            dateRepository.Add(new Dates
            {
                id = 13,
                idDoctor = 1,
                Date = new DateTime(2015, 1, 15)
            });

            dateRepository.Add(new Dates
            {
                id = 14,
                idDoctor = 5,
                Date = new DateTime(2015, 4, 10)
            });

            dateRepository.Add(new Dates
            {
                id = 15,
                idDoctor = 2,
                Date = new DateTime(2015, 1, 16)
            });
        }
    }
}