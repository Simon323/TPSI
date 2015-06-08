using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using REST.Model.Entity;
using REST.Model.Model;

namespace REST.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            bool condition = true;
            Helpers helpers = new Helpers();

            while (condition)
            {

                Console.WriteLine("1) Dodaj lekarza");
                Console.WriteLine("2) Dodaj terminu");
                Console.WriteLine("3) Pobieranie lekarza danej specjalizacji w danym mieście");
                Console.WriteLine("4) Pobieranie informacji o danym lekarzu");
                Console.WriteLine("5) Dodaj opinię do lekarza");
                Console.WriteLine("6) Wyszukaj termin w kontekście daty i statusu");
                Console.WriteLine("7) Rezerwuj wizytę");
                Console.WriteLine("8) Anuluj wizytę");
                

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Clear();
                        Doctors doctor = new Doctors();

                        Console.Write("Name : ");
                        doctor.Name = Console.ReadLine();
                        Console.Write("Surname : ");
                        doctor.Surname = Console.ReadLine();
                        Console.Write("City : ");
                        doctor.City = Console.ReadLine();
                        Console.Write("Specialization : ");
                        doctor.Specialization = Console.ReadLine();

                        helpers.AddDoctor(doctor);
                        Console.WriteLine("Dodano doktora");

                        break;
                    case "2":

                        Console.Clear();
                        Visits visit = new Visits();

                        Console.Write("IdDoctor : ");
                        visit.IdDoctor = new ObjectId(Console.ReadLine());
                        //string dateString = Console.ReadLine();
                        Console.WriteLine("Date : ");
                        visit.Date = Convert.ToDateTime(Console.ReadLine()); 
                        Console.Write("IsFree : ");
                        visit.IsFree = Convert.ToBoolean(Console.ReadLine());

                        helpers.AddVisit(visit);
                        Console.WriteLine("Dodano nowy termin wizyty");

                        break;
                    case "3":

                        Console.Clear();
                        Console.Write("Miasto : ");
                        string cityP3 = Console.ReadLine();
                        Console.Write("Specialization : ");
                        string specializationP3 = Console.ReadLine();
                        Console.WriteLine();

                        var doctorsList = helpers.GetDoctorsByCityAndSpecialization(cityP3, specializationP3);

                        foreach (var element in doctorsList)
                        {
                            Console.WriteLine("Name : " + element.Name + ", Surname : " + element.Surname);
                        }
                        
                        break;
                    case "4":

                        Console.Clear();
                        Console.Write("Id Doctor : ");
                        string idDoctorP4 = Console.ReadLine();
                        Console.WriteLine();

                        DoctorModel doctorModel =  helpers.GetDoctorInformationById(idDoctorP4);

                        if (doctorModel == null)
                        {
                            Console.WriteLine("Nie znaleziono informacji.");
                        }
                        else
                        {
                            Console.WriteLine("Name : " + doctorModel.Name + ", Surname : " + doctorModel.Surname);
                            Console.WriteLine();

                            foreach (var element in doctorModel.Opinion)
                            {
                                Console.WriteLine(element);
                            }
                        }

                        break;
                    case "5":

                        Console.Clear();
                        Reviews review = new Reviews();
                        Console.Write("Id Doctor : ");
                        review.IdDoctor = new ObjectId(Console.ReadLine());
                        Console.Write("Description : ");
                        review.Description = Console.ReadLine();
                        Console.WriteLine();

                        helpers.AddOpinion(review);
                        Console.WriteLine("Dodano opinie");

                        break;
                    case "6":

                        Console.Clear();

                        Console.Write("Date : ");
                        DateTime dateP6 = Convert.ToDateTime(Console.ReadLine()); 
                        Console.Write("IsFree : ");
                        bool isFreeP6 = Convert.ToBoolean(Console.ReadLine());
                        Console.WriteLine();

                        var visitsList = helpers.GetVisitsByDateAndStatus(dateP6, isFreeP6);

                        foreach (var element in visitsList)
                        {
                            Console.WriteLine("Date : " + element.Date.ToString() + ", Id Doctor : " + element.IdDoctor.ToString());
                        }

                        break;
                    case "7":

                        Console.Clear();
                        Patient patient = new Patient();

                        Console.Write("Id Visit : ");
                        string idP7 = Console.ReadLine();
                        Console.Write("Name : ");
                        patient.Name = Console.ReadLine();
                        Console.Write("Surname : ");
                        patient.Surname = Console.ReadLine();
                        Console.WriteLine();

                        helpers.BookVisit(idP7, patient);

                        Console.WriteLine("Dokonano rezerwacji");
                        break;
                    case "8":
                        break;
                    default: 
                        Console.WriteLine("Nie znaleziono dopasowania."); 
                        break;
                }

                Console.ReadKey();
                System.Console.Clear();
            }
        }
    }
}
