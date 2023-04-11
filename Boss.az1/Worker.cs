using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boss.az1
{
    public class Worker
    {
        public Worker(string? username, string? password, string? name, string? surname, string? city, string? phoneNumber, int age)
        {
            Id = ++ID;

            Username = username;
            Password = password;
            Name = name;
            Surname = surname;
            City = city;
            PhoneNumber = phoneNumber;
            Age = age;

        }
        public Worker() { }

        static int ID { get; set; } = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public int Age { get; set; }
        public CV Cv { get; set; } = null;
        public string Username { get; set; }
        public string Password { get; set; }
        public Notifications Notifications { get; set; } = new Notifications();
        public List<Employer> Applicant { get; set; } = new List<Employer>();
        public List<Vacancy> ApplicantVacancy { get; set; } = new List<Vacancy>();

        public void AddCv(CV cv)
        {
            this.Cv = cv;
        }
        public void Show()
        {
            Console.WriteLine($"Id : {Id}");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Surname : {Surname}");
            Console.WriteLine($"Age : {Age}");
            Console.WriteLine($"City : {City}");
            Console.WriteLine($"Phone Number : {PhoneNumber}");
        }
        public void ShowCV()
        {
            Console.WriteLine($"Speciality : {Cv.Speciality}");
            Console.WriteLine($"School : {Cv.SchoolName}");
            Console.WriteLine($"University : {Cv.ExamPoint}");
            Cv.Skills.ForEach(s => Console.WriteLine($"Skill : {s}"));
            Cv.Companies.ForEach(c => Console.WriteLine($"Companie : {c}"));
            Console.WriteLine($"Work start end : {Cv.PractiseTime}");
            Cv.Language.ForEach(l => Console.WriteLine($"Language : {l}"));
            if (Cv.HonorsDiplom)
            {
                Console.WriteLine($"Honors diploma : Yes");
            }
            else
            {
                Console.WriteLine($"Honors diploma : No");
            }
            if (Cv.GitLink != null)
            {
                Console.WriteLine($"Github link : {Cv.GitLink}");
            }
            if (Cv.Linkedin != null)
            {
                Console.WriteLine($"Linkedin link : {Cv.Linkedin}");
            }
        }
    }
}
