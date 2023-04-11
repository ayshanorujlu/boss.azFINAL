﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boss.az1
{
    class BossPr
    {
        public List<Worker> Workers = new List<Worker>();
        public List<Employer> Employers = new List<Employer>();

        #region SiteName
        static void SiteName()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("$$$$$$$\\   $$$$$$\\   $$$$$$\\   $$$$$$\\       $$$$$$\\  $$$$$$$$\\ ");
            Console.WriteLine("$$  __$$\\ $$  __$$\\ $$  __$$\\ $$  __$$\\     $$  __$$\\ \\____$$  |");
            Console.WriteLine("$$ |  $$ |$$ /  $$ |$$ /  \\__|$$ /  \\__|    $$ /  $$ |    $$  / ");
            Console.WriteLine("$$$$$$$\\ |$$ |  $$ |\\$$$$$$\\  \\$$$$$$\\      $$$$$$$$ |   $$  /  ");
            Console.WriteLine("$$  __$$\\ $$ |  $$ | \\____$$\\  \\____$$\\     $$  __$$ |  $$  /   ");
            Console.WriteLine("$$ |  $$ |$$ |  $$ |$$\\   $$ |$$\\   $$ |    $$ |  $$ | $$  /    ");
            Console.WriteLine("$$$$$$$  | $$$$$$  |\\$$$$$$  |\\$$$$$$  |$$\\ $$ |  $$ |$$$$$$$$\\ ");
            Console.WriteLine("\\_______/  \\______/  \\______/  \\______/ \\__|\\__|  \\__|\\________|");
            Console.WriteLine("                                                                ");
            Console.WriteLine("                                                                ");
            Console.WriteLine("                                                                ");
            Console.ForegroundColor = ConsoleColor.Black;

        }
        #endregion


        static public void CreatCV(Worker worker, List<Worker> workers, int index)
        {
            Console.Write("Speciality : ");
            var speciality = Console.ReadLine();
            Console.Write("School : ");
            var school = Console.ReadLine();
            Console.Write("University : ");
            var uni = Console.ReadLine();
            Console.Write("Skill : ");
            var skill = Console.ReadLine();
            var skills = new List<string> { };
            skills.Add(skill);

            Console.Write("Do you want to improve your skills? ");

            while (true)
            {

                Console.Write("YES or NO : ");
                var result = Console.ReadLine();
                if (result.ToLower() == "yes")
                {
                    Console.Write("Enter new skill : ");
                    var skillnew = Console.ReadLine();
                    skills.Add(skillnew);

                }
                else if (result.ToLower() == "no")
                {
                    break;
                }
            }
            Console.Write("Companies : ");
            var companies = Console.ReadLine();
            var companies11 = new List<string> { };
            companies11.Add(companies);
            Console.Write("Do you want to improve your companies? ");
            while (true)
            {
                Console.Write("YES or NO : ");
                var result = Console.ReadLine();
                if (result.ToLower() == "yes")
                {
                    Console.Write("Enter new companies : ");
                    var companies1 = Console.ReadLine();
                    companies11.Add(companies1);

                }
                else if (result.ToLower() == "no")
                {
                    break;
                }
            }
            Console.Write("Enter language : ");
            var language = Console.ReadLine();
            var languages = new List<string> { };
            languages.Add(language);
            Console.Write("Do you want to improve your languages? ");
            while (true)
            {
                Console.Write("YES or NO: ");
                var result = Console.ReadLine();
                if (result.ToLower() == "yes")
                {
                    Console.Write("Enter languages : ");
                    var language1 = Console.ReadLine();
                    languages.Add(language1);

                }
                else if (result.ToLower() == "no")
                {
                    break;
                }
            }
            Console.Write("When is your work start?  ");
            var start = Console.ReadLine();
            Console.Write("When is your work end?  ");
            var end = Console.ReadLine();
            Console.Write("Honors Diploma (YES or NO ) : ");
            var result1 = Console.ReadLine();
            bool HonorsDiploma = false;
            if (result1.ToLower() == "yes")
            {
                HonorsDiploma = true;
            }
            Console.Write("GITLink (YES or NO ) : ");
            var result3 = Console.ReadLine();
            string gitlink = null;
            if (result3.ToLower() == "yes")
            {
                gitlink = Console.ReadLine();
            }
            Console.Write("LinkedIN (YES or NO ) : ");
            var result2 = Console.ReadLine();
            string linkedin = null;
            if (result2.ToLower() == "yes")
            {
                linkedin = Console.ReadLine();
            }
            CV cV = new CV()
            {
                Speciality = speciality,
                SchoolName = school,
                Skills = skills,
                Companies = companies11,
                PractiseTime = $"{start} || {end}",
                Language = languages,
                HonorsDiplom = HonorsDiploma,
                GitLink = gitlink,
                Linkedin = linkedin
            };

            worker.AddCv(cV);

        }

        static public void Worker(Worker worker, List<Employer> employers, int index1, List<Worker> workers)
        {
            string a = "\n\t\t\t\t\t\t";
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"{a}Welcome {worker.Name} {worker.Surname}");
                Console.WriteLine();
                Console.WriteLine("[1] Show cv");
                Console.WriteLine("[2] Search vacancy");
                Console.WriteLine("[3] Update cv");
                Console.WriteLine("[4] Creat cv");
                Console.WriteLine("[5] Notification");
                Console.WriteLine("[6] Sign Out");
                Console.Write("Select : ");
                string select = Console.ReadLine();
                if (select == "1")
                {
                    if (worker.Cv != null)
                    {
                        Console.Clear();
                        Console.WriteLine("Your CV");
                        worker.ShowCV();
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("You have no CV. Please create your Cv!");
                        Console.ResetColor();
                        Console.ReadKey();
                    }
                }
                else if (select == "2")
                {
                    string search = String.Empty;
                    int result;
                    while (true)
                    {
                        var letter = Console.ReadKey();
                        if (letter.Key == ConsoleKey.D1 || letter.Key == ConsoleKey.D2 ||
                            letter.Key == ConsoleKey.D3 || letter.Key == ConsoleKey.D4 ||
                            letter.Key == ConsoleKey.D5 || letter.Key == ConsoleKey.D6 ||
                            letter.Key == ConsoleKey.D7 || letter.Key == ConsoleKey.D8 ||
                            letter.Key == ConsoleKey.D9)
                        {
                            var result1 = letter.Key.ToString();
                            result1 = result1.Replace('D', ' ');
                            result = int.Parse(result1);
                            break;
                        }
                        Console.Clear();
                        search += letter.KeyChar;
                        search = search.ToLower();
                        if (letter.Key == ConsoleKey.Backspace)
                        {
                            search = "";
                        }
                        Console.WriteLine(search);
                        var selectedVacancy = from e in employers
                                              from v in e.Vacancies
                                              where v.Speciality.ToLower().Contains(search)
                                              select v;
                        foreach (var vacancy in selectedVacancy)
                        {
                            Console.WriteLine($"{vacancy.Id} - {vacancy.Speciality}");
                        }
                        Console.WriteLine("\n\n");
                    }
                    Console.Clear();
                    var vacancy1 = from e in employers
                                   from v in e.Vacancies
                                   where v.Id == result
                                   select v;
                    Vacancy vacancyResult = new Vacancy();
                    foreach (var vacancy in vacancy1)
                    {
                        vacancyResult = vacancy;
                    }
                    vacancyResult.ShowVacancy();
                    Console.WriteLine("[1] Apply");
                    Console.WriteLine("[2] Back");
                    Console.Write("Select : ");
                    var select1 = Console.ReadLine();
                    if (select1 == "1")
                    {
                        for (int i = 0; i < employers.Count; i++)
                        {
                            for (int k = 0; k < employers[i].Vacancies.Count; k++)
                            {
                                if (result == employers[i].Vacancies[k].Id)
                                {
                                    employers[i].Notifications.Count += 1;
                                    employers[i].Applicant.Add(worker);
                                    employers[i].ApplicantVacancy.Add(vacancyResult);
                                }
                            }
                        }
                        Notifications notification = new Notifications();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Request sent!");
                        Console.ResetColor();
                        Console.ReadKey();
                    }
                    else if (select == "2") { }
                }
                else if (select == "3")
                {
                    if (worker.Cv != null)
                    {
                        Console.Clear();
                        Console.WriteLine("CV");
                        worker.ShowCV();
                        Console.WriteLine("[1] Speciality");
                        Console.WriteLine("[2] School Name");
                        Console.WriteLine("[3] Skills");
                        Console.WriteLine("[4] Companies ");
                        Console.WriteLine("[5] Language");
                        Console.WriteLine("[6] HonorsDiploma");
                        Console.WriteLine("[7] GitLink");
                        Console.WriteLine("[8] Linkedin");
                        Console.WriteLine("[9] Back");
                        Console.Write("Select : ");
                        var select1 = Console.ReadLine();
                        if (select1 == "1")
                        {
                            Console.Write("Enter new speciality : ");
                            var result = Console.ReadLine();
                            worker.Cv.Speciality = result;
                            workers[index1].Cv.Speciality = result;
                        }
                        else if (select1 == "2")
                        {
                            Console.Write("Enter new school : ");
                            var result = Console.ReadLine();
                            worker.Cv.SchoolName = result;
                            workers[index1].Cv.SchoolName = result;
                        }

                        else if (select1 == "3")
                        {
                            Console.Write("Add or uptade? (1/2) : ");
                            var choise = Console.ReadLine();
                            if (choise == "1")
                            {
                                Console.Write("Enter skill : ");
                                var skill = Console.ReadLine();
                                worker.Cv.Skills.Add(skill);
                                workers[index1].Cv.Skills.Add(skill);
                                Console.Write("Want to add a new skill?");
                                while (true)
                                {
                                    Console.Write("Yes / No : ");
                                    var result = Console.ReadLine();
                                    if (result.ToLower() == "yes")
                                    {
                                        Console.Write("Enter skill : ");
                                        var skill1 = Console.ReadLine();
                                        worker.Cv.Skills.Add(skill1);
                                        workers[index1].Cv.Skills.Add(skill1);
                                    }
                                    else if (result.ToLower() == "no")
                                    {
                                        break;
                                    }
                                }
                            }
                            else if (choise == "2")
                            {
                                bool flag = true;
                                while (flag)
                                {
                                    Console.Clear();
                                    worker.Cv.Skills.ForEach(s => Console.WriteLine($"Skill : {s}"));
                                    Console.Write("Enter skill name : ");
                                    var skill = Console.ReadLine();
                                    foreach (var skill1 in worker.Cv.Skills)
                                    {
                                        if (skill == skill1)
                                        {
                                            Console.Write("Enter new skill name : ");
                                            var result = Console.ReadLine();
                                            var index = worker.Cv.Skills.IndexOf(skill1);
                                            worker.Cv.Skills[index] = result;
                                            workers[index1].Cv.Skills[index] = result;
                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.Write("Succesfully ! ");
                                            Console.ResetColor();
                                            Console.ReadKey();
                                            flag = false;
                                            break;
                                        }
                                    }
                                    if (flag)
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.WriteLine("Skill not found!");
                                        Console.ResetColor();
                                        Console.ReadKey();
                                    }
                                }
                            }
                        }
                        else if (select1 == "4")
                        {
                            Console.Write("Add or uptade? (1/2) : ");
                            var choise = Console.ReadLine();
                            if (choise == "1")
                            {
                                Console.Write("Enter companies : ");
                                var companies = Console.ReadLine();
                                worker.Cv.Companies.Add(companies);
                                workers[index1].Cv.Companies.Add(companies);
                                Console.Write("Want to add a new companies?");
                                while (true)
                                {
                                    Console.Write("Yes / No : ");
                                    var result = Console.ReadLine();
                                    if (result.ToLower() == "yes")
                                    {
                                        Console.Write("Enter companies : ");
                                        var companies1 = Console.ReadLine();
                                        worker.Cv.Companies.Add(companies1);
                                        workers[index1].Cv.Companies.Add(companies1);
                                    }
                                    else if (result.ToLower() == "no")
                                    {
                                        break;
                                    }
                                }
                            }
                            else if (choise == "2")
                            {
                                bool flag = true;
                                while (flag)
                                {
                                    Console.Clear();
                                    worker.Cv.Companies.ForEach(s => Console.WriteLine($"Companies : {s}"));
                                    Console.Write("Enter companies name : ");
                                    var companies = Console.ReadLine();
                                    foreach (var companies1 in worker.Cv.Companies)
                                    {
                                        if (companies == companies1)
                                        {
                                            Console.Write("Enter new companies name : ");
                                            var result = Console.ReadLine();
                                            var index = worker.Cv.Companies.IndexOf(companies1);
                                            worker.Cv.Companies[index] = result;
                                            workers[index1].Cv.Companies[index] = result;
                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.Write("Succesfully ! ");
                                            Console.ResetColor();
                                            Console.ReadKey();
                                            flag = false;
                                            break;
                                        }
                                    }
                                    if (flag)
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.WriteLine("Companies not found!");
                                        Console.ResetColor();
                                        Console.ReadKey();
                                    }
                                }
                            }
                        }
                        else if (select1 == "5")
                        {
                            Console.Write("Add or uptade? (1/2) : ");
                            var choise = Console.ReadLine();
                            if (choise == "1")
                            {
                                Console.Write("Enter language : ");
                                var language = Console.ReadLine();
                                worker.Cv.Language.Add(language);
                                workers[index1].Cv.Language.Add(language);
                                Console.Write("Want to add a new language?");
                                while (true)
                                {
                                    Console.Write("Yes / No : ");
                                    var result = Console.ReadLine();
                                    if (result.ToLower() == "yes")
                                    {
                                        Console.Write("Enter language : ");
                                        var language1 = Console.ReadLine();
                                        worker.Cv.Language.Add(language1);
                                        workers[index1].Cv.Language.Add(language1);
                                    }
                                    else if (result.ToLower() == "no")
                                    {
                                        break;
                                    }
                                }
                            }
                            else if (choise == "2")
                            {
                                bool flag = true;
                                while (flag)
                                {
                                    Console.Clear();
                                    worker.Cv.Language.ForEach(s => Console.WriteLine($"Language : {s}"));
                                    Console.Write("Enter language name : ");
                                    var language = Console.ReadLine();
                                    foreach (var language1 in worker.Cv.Language)
                                    {
                                        if (language == language1)
                                        {
                                            Console.Write("Enter new language name : ");
                                            var result = Console.ReadLine();
                                            var index = worker.Cv.Language.IndexOf(language1);
                                            worker.Cv.Language[index] = result;
                                            workers[index1].Cv.Language[index] = result;
                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.Write("Succesfully ! ");
                                            Console.ResetColor();
                                            Console.ReadKey();
                                            flag = false;
                                            break;
                                        }
                                    }
                                    if (flag)
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.WriteLine("Language not found!");
                                        Console.ResetColor();
                                        Console.ReadKey();
                                    }
                                }
                            }
                        }
                        else if (select1 == "6")
                        {
                            if (worker.Cv.HonorsDiplom == false)
                            {
                                Console.Write("Add an honors diploma? (y/n) : ");
                                var result = Console.ReadLine();
                                if (result.ToLower() == "y")
                                {
                                    worker.Cv.HonorsDiplom = true;
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.Write("Succesfully ! ");
                                    Console.ResetColor();
                                    Console.ReadKey();
                                }
                                else if (result.ToLower() == "n") { }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("You have a diploma of distinction");
                                Console.ResetColor();
                                Console.ReadKey();
                            }
                        }
                        else if (select1 == "7")
                        {
                            if (worker.Cv.GitLink == null)
                            {
                                Console.Write("Enter gitlink : ");
                                var result = Console.ReadLine();
                                worker.Cv.GitLink = result;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("You have a github link");
                                Console.ResetColor();
                                Console.ReadKey();
                            }
                        }
                        else if (select1 == "8")
                        {
                            if (worker.Cv.Linkedin == null)
                            {
                                Console.Write("Enter linkedin link : ");
                                var result = Console.ReadLine();
                                worker.Cv.GitLink = result;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("You have a linkedin");
                                Console.ResetColor();
                                Console.ReadKey();
                            }
                        }
                        else if (select1 == "9")
                        {
                            Worker(worker, employers, index1, workers);
                        }

                    }
                    else
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("You have no CV. Please create your Cv !");
                        Console.ResetColor();
                        Console.ReadKey();
                    }
                }
                else if (select == "4")
                {
                    if (worker.Cv == null)
                    {
                        CreatCV(worker, workers, index1);
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("You already have a CV !");
                        Console.ResetColor();
                        Console.ReadKey();
                    }
                }
                else if (select == "5")
                {
                    if (worker.Applicant.Count != 0)
                    {
                        worker.Applicant.ForEach(e => e.Show());
                        worker.ApplicantVacancy.ForEach(v => v.ShowVacancy());
                        Console.WriteLine(worker.Notifications.Content);
                        Console.ReadKey();
                        worker.Applicant.Clear();
                        worker.ApplicantVacancy.Clear();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("There is no information.");
                        Console.ResetColor();
                        Console.ReadKey();
                    }
                }
                else if (select == "6")
                {
                    return;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid select !");
                    Console.ResetColor();
                    Console.ReadKey();
                }

            }
        }

        static public void Employer(Employer employer, List<Employer> employers)
        {
            string a = "\n\t\t\t\t\t\t";
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"{a}Welcome {employer.Name} {employer.Surname}");
                Console.WriteLine();
                Console.WriteLine("[1] Notifications");
                Console.WriteLine("[2] Add Vacancy");
                Console.WriteLine("[3] Update Vacancy");
                Console.WriteLine("[4] Show Vacancy");
                Console.WriteLine("[5] Sign Out");
                Console.Write("Select : ");
                string select = Console.ReadLine();
                if (select == "1")
                {
                    if (employer.Applicant.Count != 0)
                    {
                        Vacancy vacancy = new Vacancy();
                        var result1 = employer.ApplicantVacancy.Select(v => v);
                        foreach (var v in result1)
                        {
                            vacancy = v;
                        }
                        employer.Applicant.ForEach(w => w.Show());
                        employer.Applicant.ForEach(w => w.ShowCV());
                        employer.ApplicantVacancy.ForEach(v => v.ShowVacancy());
                        Console.WriteLine("[1] Accept");
                        Console.WriteLine("[2] Reject");
                        Console.Write("Choice : ");
                        var choice = Console.ReadLine();
                        if (choice == "1")
                        {
                            Worker worker = null;
                            var result = employer.Applicant.Select(w => w);
                            foreach (var w in result)
                            {
                                worker = w;
                            }
                            worker.Applicant.Add(employer);
                            worker.ApplicantVacancy.Add(vacancy);
                            worker.Notifications.Content = "Accepted";
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Message sended");
                            Console.ResetColor();
                            Console.ReadKey();
                            employer.Applicant.Clear();
                            employer.ApplicantVacancy.Clear();
                            employer.Vacancies.Remove(vacancy);

                        }
                        else if (choice == "2")
                        {
                            Worker worker = null;
                            var result = employer.Applicant.Select(w => w);
                            foreach (var w in result)
                            {
                                worker = w;
                            }
                            worker.Applicant.Add(employer);
                            worker.ApplicantVacancy.Add(vacancy);
                            worker.Notifications.Content = "Rejected";
                            Console.ReadKey();
                            employer.Applicant.Clear();
                            employer.ApplicantVacancy.Clear();
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("NO INFO!");
                        Console.ResetColor();
                        Console.ReadKey();
                    }

                }
                else if (select == "2")
                {
                    Console.Write("Speciality : ");
                    var speciality = Console.ReadLine();
                    Console.Write("Salary : ");
                    var salary = double.Parse(Console.ReadLine());
                    Console.Write("Experience Year : ");
                    var experienceYear = int.Parse(Console.ReadLine());
                    Vacancy vac = new Vacancy(speciality, salary, experienceYear);
                    employer.Vacancies.Add(vac);

                }
                else if (select == "3")
                {
                    employer.Vacancies.ForEach(v => v.ShowVacancy());
                    Console.Write("Vacancy ID : ");
                    var id = int.Parse(Console.ReadLine());
                    var vacancy = employer.GetVacancyById(id);
                    if (vacancy != null)
                    {
                        Console.WriteLine("[1] Speciality");
                        Console.WriteLine("[2] Salary");
                        Console.WriteLine("[3] Practise year");
                        Console.Write("Select the choice : ");
                        var choice = Console.ReadLine();
                        if (choice == "1")
                        {
                            Console.Write("New speciality : ");
                            var speciality = Console.ReadLine();
                            vacancy.Speciality = speciality;

                        }
                        else if (choice == "2")
                        {
                            Console.Write("New salary : ");
                            var salary = double.Parse(Console.ReadLine());
                            vacancy.Salary = salary;

                        }
                        else if (choice == "3")
                        {
                            Console.Write("New practise year : ");
                            var experienceYear = int.Parse(Console.ReadLine());
                            vacancy.PractiseYear = experienceYear;

                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Invalid entry!!!");
                            Console.ResetColor();
                            Console.ReadKey();
                        }

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("This vacancy not found!");
                        Console.ResetColor();
                        Console.ReadKey();
                    }
                }
                else if (select == "4")
                {
                    if (employer.Vacancies.Count != 0)
                    {
                        employer.Vacancies.ForEach(v => v.ShowVacancy());
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("You have not vacancy !!");
                        Console.ResetColor();
                        Console.ReadKey();
                    }

                }
                else if (select == "5")
                {
                    return;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid sleect !");
                    Console.ResetColor();
                    Console.ReadKey();
                }
            }
        }

        static public void Start()
        {
            List<Worker> workers = new List<Worker>();
            Worker w1 = new Worker("ayshan666", "ayshan99", "Ayshan", "Orujlu", "Baku", "+994508798989", 27);
            Worker w2 = new Worker("jahangir777", "jahangir99", "Jahangir", "Abbasov", "Sheki", "+994709876534", 28);
            Worker w3 = new Worker("sevinc888", "sevinc99", "Sevinc", "Piriyeva", "Georgia", "+99555555675", 35);




            w1.AddCv(new CV()
            {
                Speciality = ".NET Developer",
                SchoolName = "20",
                ExamPoint = "ASOIU",
                Skills = new List<string> { "C++", "Python" },
                Companies = new List<string> { "Socar", "Azercell" },
                PractiseTime = "09/09/2017 || 10/06/2021",
                Language = new List<string> { "English", "Russian" },
                HonorsDiplom = true,
                GitLink = "github.com/ayshan123"
            });


            workers.Add(w1);
            workers.Add(w2);
            workers.Add(w3);


            WriteRead.WriteWorker(workers);
            workers = WriteRead.ReadWorker();






            List<Employer> employers = new List<Employer>();
            Employer emp1 = new Employer("vaqif7", "vaqa", "Vaqif", "Akhmedov", "Baku", "+9948795432", 43);
            Employer emp2 = new Employer("elnara7", "eno", "Elnara", "Bairamova", "Baku", "+9946785432", 38);
            emp1.Vacancies.Add(new Vacancy("Middle C# Developer", 5000, 4));
            emp1.Vacancies.Add(new Vacancy("Interior Design", 4000, 5));
            employers.Add(emp1);
            employers.Add(emp2);

            WriteRead.WriteEmployer(employers);
            employers = WriteRead.ReadEmployer();

            while (true)
            {
                Console.Clear();
                SiteName();
                Console.WriteLine("\n\t\t\t\t\t\t[1] Log in ");
                Console.WriteLine("\n\t\t\t\t\t\t[2] Sign up ");
                Console.WriteLine("\n\t\t\t\t\t\t[3] Log out ");
                Console.Write("\n\t\t\t\t\t\tSelect : ");
                string choice = Console.ReadLine();
                Worker worker = null;
                int wIndex = 0;
                Employer employer = null;
                int eIndex = 0;
                if (choice == "1")
                {
                    #region LogIn
                    Console.WriteLine(" __        ______     _______     __  .__   __. ");
                    Console.WriteLine("|  |      /  __  \\   /  _____|   |  | |  \\ |  | ");
                    Console.WriteLine("|  |     |  |  |  | |  |  __     |  | |   \\|  | ");
                    Console.WriteLine("|  |     |  |  |  | |  | |_ |    |  | |  . `  | ");
                    Console.WriteLine("|  `----.|  `--'  | |  |__| |    |  | |  |\\   | ");
                    Console.WriteLine("|_______| \\______/   \\______|    |__| |__| \\__| ");
                    Console.WriteLine("                                                ");
                    Console.WriteLine("                                                ");
                    Console.WriteLine("                                                ");
                    Console.WriteLine("                                                ");
                    Console.WriteLine("                                                ");
                    Console.WriteLine("                                                ");
                    #endregion
                    Console.Write("\n\t\t\t\t\t\t Username : ");
                    string username = Console.ReadLine();
                    Console.Write("\n\t\t\t\t\t\t Password : ");
                    string password = Console.ReadLine();
                    for (int i = 0; i < workers.Count; i++)
                    {
                        if (username == workers[i].Username && password == workers[i].Password)
                        {
                            worker = workers[i];
                            wIndex = i;
                        }
                    }
                    for (int i = 0; i < employers.Count; i++)
                    {
                        if (username == employers[i].Username && password == employers[i].Password)
                        {
                            employer = employers[i];
                            eIndex = i;
                        }
                    }
                    if (worker != null)
                    {
                        Worker(worker, employers, wIndex, workers);
                    }
                    else if (employer != null)
                    {
                        Employer(employer, employers);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\t\t\t\t\t\tUser not found!!!");
                        Console.ResetColor();
                        Console.ReadKey();
                    }
                }
                else if (choice == "2")
                {
                    #region SignUp
                    Console.WriteLine("     _______. __    _______ .__   __.     __    __  .______   ");
                    Console.WriteLine("    /       ||  |  /  _____||  \\ |  |    |  |  |  | |   _  \\  ");
                    Console.WriteLine("   |   (----`|  | |  |  __  |   \\|  |    |  |  |  | |  |_)  | ");
                    Console.WriteLine("    \\   \\    |  | |  | |_ | |  . `  |    |  |  |  | |   ___/  ");
                    Console.WriteLine(".----)   |   |  | |  |__| | |  |\\   |    |  `--'  | |  |      ");
                    Console.WriteLine("|_______/    |__|  \\______| |__| \\__|     \\______/  | _|      ");
                    Console.WriteLine("                                                              ");
                    Console.WriteLine("                                                              ");
                    Console.WriteLine("                                                              ");
                    Console.WriteLine("                                                              ");
                    Console.WriteLine("                                                              ");
                    Console.WriteLine("                                                              ");
                    Console.WriteLine("                                                              ");
                    Console.WriteLine("                                                              ");
                    #endregion

                    Console.WriteLine("\n\t\t\t\t\t\t[1] Worker");
                    Console.WriteLine("\n\t\t\t\t\t\t[2] Employer");
                    var select1 = Console.ReadLine();
                    if (select1 == "1")
                    {
                        #region SelectWorker

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("                     _             ");
                        Console.WriteLine("                    | |            ");
                        Console.WriteLine(" __      _____  _ __| | _____ _ __ ");
                        Console.WriteLine(" \\ \\ /\\ / / _ \\| '__| |/ / _ \\ '__|");
                        Console.WriteLine("  \\ V  V / (_) | |  |   <  __/ |   ");
                        Console.WriteLine("   \\_/\\_/ \\___/|_|  |_|\\_\\___|_|   ");
                        Console.WriteLine("                                   ");
                        Console.WriteLine("                                   ");
                        Console.ForegroundColor = ConsoleColor.Black;


                        #endregion

                        Console.Write("Name : ");
                        var name = Console.ReadLine();
                        Console.Write("Surname : ");
                        var surname = Console.ReadLine();
                        Console.Write("Age : ");
                        var age = int.Parse(Console.ReadLine());
                        Console.Write("City : ");
                        var city = Console.ReadLine();
                        Console.Write("Phone number : ");
                        var phone = Console.ReadLine();
                        Console.Write("Username : ");
                        var username = Console.ReadLine();
                        Console.Write("Password : ");
                        var password = Console.ReadLine();
                        Worker worker1 = new Worker(username, password, name, surname, city, phone, age);
                        Console.WriteLine("Do you want to add CV ?");
                        Console.WriteLine("[1] YES");
                        Console.WriteLine("[2] NO");
                        var choice1 = Console.ReadLine();
                        if (choice1 == "1")
                        {
                            CreatCV(worker1, workers, wIndex);
                        }
                        workers.Add(worker1);

                    }
                    else if (select1 == "2")
                    {
                        #region SelectEmployer

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("                       _                       ");
                        Console.WriteLine("                      | |                      ");
                        Console.WriteLine("   ___ _ __ ___  _ __ | | ___  _   _  ___ _ __ ");
                        Console.WriteLine("  / _ \\ '_ ` _ \\| '_ \\| |/ _ \\| | | |/ _ \\ '__|");
                        Console.WriteLine(" |  __/ | | | | | |_) | | (_) | |_| |  __/ |   ");
                        Console.WriteLine("  \\___|_| |_| |_| .__/|_|\\___/ \\__, |\\___|_|   ");
                        Console.WriteLine("                | |             __/ |          ");
                        Console.WriteLine("                |_|            |___/           ");
                        Console.ForegroundColor = ConsoleColor.Black;


                        #endregion
                        Console.Write("Name : ");
                        var name = Console.ReadLine();
                        Console.Write("Surname : ");
                        var surname = Console.ReadLine();
                        Console.Write("Age : ");
                        var age = int.Parse(Console.ReadLine());
                        Console.Write("City : ");
                        var city = Console.ReadLine();
                        Console.Write(" Phone Number : ");
                        var phone = Console.ReadLine();
                        Console.Write("Creat Username : ");
                        var username = Console.ReadLine();
                        Console.Write("Creat Password : ");
                        var password = Console.ReadLine();
                        Employer employer1 = new Employer(username, password, name, surname, city, phone, age);
                        employers.Add(employer1);

                    }
                    Console.WriteLine("User added succesfully ! ");
                    Console.ReadKey();
                }
                else if (choice == "3")
                {
                    #region LogOut
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" __        ______     _______      ______    __    __  .___________.");
                    Console.WriteLine("|  |      /  __  \\   /  _____|    /  __  \\  |  |  |  | |           |");
                    Console.WriteLine("|  |     |  |  |  | |  |  __     |  |  |  | |  |  |  | `---|  |----`");
                    Console.WriteLine("|  |     |  |  |  | |  | |_ |    |  |  |  | |  |  |  |     |  |     ");
                    Console.WriteLine("|  `----.|  `--'  | |  |__| |    |  `--'  | |  `--'  |     |  |     ");
                    Console.WriteLine("|_______| \\______/   \\______|     \\______/   \\______/      |__|     ");
                    Console.WriteLine("                                                                    ");
                    Console.WriteLine("                                                                    ");
                    Console.WriteLine("                                                                    ");
                    Console.WriteLine("                                                                    ");
                    Console.ForegroundColor = ConsoleColor.Black;
                    #endregion
                    break;
                }
            }
        }

    }
}
