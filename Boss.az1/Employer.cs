using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boss.az1
{
    public class Employer
    {
        public Employer(string? username, string? password, string? name, string? surname, string? city, string? phoneNumber, int age)
        {
            Username = username;
            Password = password;
            Id = ++ID;
            Name = name;
            Surname = surname;
            City = city;
            PhoneNumber = phoneNumber;
            Age = age;


        }
        public Employer() { }
        public string Username { get; set; }
        public string Password { get; set; }
        static int ID { get; set; } = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public int Age { get; set; }
        public static int Count { get; set; }
        public Notifications Notifications { get; set; } =
            new Notifications();
        public List<Vacancy> Vacancies { get; set; } = new List<Vacancy>();
        public List<Worker> Workers { get; set; } = null;

        public List<Worker> Applicant { get; set; } = new List<Worker>();
        public List<Vacancy> ApplicantVacancy { get; set; } = new List<Vacancy>();

        public void Show()
        {
            Console.WriteLine($"Id : {Id}");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Surname : {Surname}");
            Console.WriteLine($"Age : {Age}");
            Console.WriteLine($"City : {City}");
            Console.WriteLine($"Phone Number : {PhoneNumber}");
        }

        public Vacancy GetVacancyById(int id)
        {
            foreach (var vacancy in Vacancies)
            {
                if (vacancy.Id == id)
                {
                    return vacancy;
                }
            }
            return null;
        }
    }
}
