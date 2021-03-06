﻿using REST.ModelORM.EntityModel;
using REST.ModelORM.Model;
using REST.ModelORM.Repository.IRepository;
using REST.DBContext.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using REST.ModelORM.Models;

namespace REST.ModelORM.Repository
{
    public class DoctorsRepository : BaseDbContextRepository<Doctor, RESTEntities>, IDoctorsRepository
    {
        public List<Doctor> GetDoctorsByCityAndSpecialization(string city, string specialization)
        {
            return Items.Where(x => x.City == city && x.Specialization == specialization).ToList();
        }

        public DoctorModel GetDoctorInformationById(int id)
        {
            DoctorModel doctorModel = new DoctorModel();

            var doctor = Items.Where(x => x.id == id).FirstOrDefault();

            #region Fill

            doctorModel.Name = doctor.Name;
            doctorModel.Surname = doctor.Surname;
            doctorModel.City = doctor.City;
            doctorModel.Specialization = doctor.Specialization;

            foreach (var element in doctor.Comments)
            {
                doctorModel.Opinion.Add(new CommentModel
                {
                    Desctiption = element.Description,
                    Date = element.Date
                });
            }

            foreach (var elemement in doctor.Visits)
            {
                doctorModel.Visits.Add(new VisitModel
                {
                    id = elemement.id,
                    PatientId = elemement.PatientId.GetValueOrDefault(),
                    IsFree = elemement.IsFree,
                    Date = elemement.Date
                });
            }

            return doctorModel;

            #endregion
        }

        public List<DoctorModel> GetDoctors()
        {
            List<DoctorModel> doctorsList = new List<DoctorModel>();
            var doctors = Items.ToList();

            foreach (var doctor in doctors)
            {
                DoctorModel element = new DoctorModel
                {
                    id = doctor.id,
                    Name = doctor.Name,
                    Surname = doctor.Surname,
                    City = doctor.City,
                    Specialization = doctor.Specialization
                };

                foreach (var comment in doctor.Comments)
                {
                    element.Opinion.Add(new CommentModel
                    {
                        Desctiption = comment.Description,
                        Date = comment.Date
                    });
                }

                foreach (var visit in doctor.Visits)
                {
                    VisitModel vis = new VisitModel
                    {
                        id = visit.id,
                        Date = visit.Date,
                        IsFree = visit.IsFree
                    };

                    element.Visits.Add(vis);
                }

                doctorsList.Add(element);
            }

            return doctorsList;
        }
    }
}
