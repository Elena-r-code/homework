using Domain.Classes;
using Domain.Enums;
using System;
using System.Collections.Generic;

namespace Homework_Fundamentals
{
    class Program
    {
        public static List<Course> Courses;
        public static List<Faculty> Faculties = new List<Faculty>();
        public static List<Professor> Profesors = new List<Professor>();
        public static List<Student> Students = new List<Student>();
        public static List<University> Universities = new List<University>();
        public static List<int> Count = new List<int>();

        public static void PrintStudents()
        {

            Console.WriteLine("Enter name of the faculty :");
            string name = Console.ReadLine();

            for (int i = 0; i < Faculties.Count; i++)
            {
                if (name.ToLower() == Faculties[i].Name.ToLower())
                {

                    foreach (Student student in Faculties[i].Students)
                    {
                        Console.WriteLine(student.Name + " " + student.Surname);
                    };
                }
                else
                {
                    break;
                }
            };

        }

        public static void PrintStudentsByCourse()
        {
            Console.WriteLine("Enter course name :");
            string courseName = Console.ReadLine();

            foreach (Course course in Courses)
            {
                if (courseName.ToLower() == course.NameOfCourse.ToLower())
                {
                    foreach (Student student in course.Students)
                    {
                        Console.WriteLine(student.Name + " " + student.Surname);
                    }
                }

            }
        }

        public static void FacultyWithGreatesNumberOfStudents()
        {
    
            int max = 0;
            int[] count = { Faculties[0].Students.Count, Faculties[1].Students.Count, Faculties[2].Students.Count, Faculties[3].Students.Count, Faculties[4].Students.Count, Faculties[5].Students.Count };
           for(int i =0; i<count.Length-1; i++)
            {
                if(count[i] > count[i + 1])
                {
                    max = count[i];
                }
                else
                {
                    max = count[i + 1];
                }
            }
            Console.WriteLine(max);
        }

        public static void StudentsPerFaculty()
        {
            for(int i =0; i < Faculties.Count; i++)
            {
                Console.WriteLine($"Facultuy name:  { Faculties[i].Name}");
                for(int j =0; i< Faculties[i].Students.Count; i++)
                {
                    Console.WriteLine($"Student name and type of student: {Faculties[i].Students[j].Name} {Faculties[i].Students[j].Surname}  {Faculties[i].Students[j].TypeOfStudent}");
                }

            }
        }
            static void Main(string[] args)
            {
                FillDataBase();
                PrintStudents();
                PrintStudentsByCourse();
                FacultyWithGreatesNumberOfStudents();
                StudentsPerFaculty();

                Console.ReadLine();
            }
            public static void FillDataBase()
            {

                Students = new List<Student>();
                Students.Add(new Student("Elena", "Betinska", true, "betinskaelena@gmail.com", DateTime.Now, 0611999495019, TypeOfStudent.Regular, "In love with Kliment", DateTime.Now));
                Students.Add(new Student("Marija", "Mladenovska", false, "mmladenovska@gmail.com", DateTime.Now, 0611999495019, TypeOfStudent.Regular, "Single", DateTime.Now));
                Students.Add(new Student("Mila", "Velkovska", false, "milavelkovska@gmail.com", DateTime.Now, 0615659495019, TypeOfStudent.Associate, "Single", DateTime.Now));
                Students.Add(new Student("Viktor", "Stojkov", false, "viktorstojkov@gmail.com", DateTime.Now, 0912456585586, TypeOfStudent.Associate, "Single", DateTime.Now));
                Students.Add(new Student("Danilo", "Borozan", true, "daniloborozan@gmail.com", DateTime.Now, 1234586564856, TypeOfStudent.Associate, "In love with Kliment", DateTime.Now));
                Students.Add(new Student("Andrej", "Ivanov", true, "andrejivanov@gmail.com", DateTime.Now, 7894561235425, TypeOfStudent.Regular, "In love with Kliment", DateTime.Now));


                Courses = new List<Course>();
                Courses.Add(new Course("C#", ".NET", 10, new List<Student> { Students[0], Students[1] }));
                Courses.Add(new Course("JS", "JavaScript", 8, new List<Student> { Students[2], Students[3] }));
                Courses.Add(new Course("SQL", "DataBase", 7, new List<Student> { Students[1], Students[4] }));
                Courses.Add(new Course("HTML", "HTML", 5, new List<Student> { Students[5], Students[3] }));
                Courses.Add(new Course("JS", "Angular", 9, new List<Student> { Students[0], Students[4] }));
                Courses.Add(new Course("CSS", "CSS", 4, new List<Student> { Students[0], Students[2] }));


                Profesors = new List<Professor>();
                Profesors.Add(new Professor("Bojan", "Damcevski", "bojandamcevski@gmail.com", new List<Course> { Courses[1], Courses[2] }));
                Profesors.Add(new Professor("Tanja", "Stojanovska", "tanjastojanovska@gmail.com", new List<Course> { Courses[0], Courses[3] }));
                Profesors.Add(new Professor("Jovana", "Miskimovska", "jovanamiskimovska@gmail.com", new List<Course> { Courses[1], Courses[4] }));
                Profesors.Add(new Professor("Aleksandar", "Manasiev", "aleksandarm@gmail.com", new List<Course> { Courses[1], Courses[2] }));
                Profesors.Add(new Professor("Stefan", "Trajkov", "stefantrajkov@gmail.com", new List<Course> { Courses[5], Courses[3] }));
                Profesors.Add(new Professor("Kliment", "Gjoreski", "klimentgjoreski@gmail.com", new List<Course> { Courses[4], Courses[1] }));

                Faculties = new List<Faculty>();
                Faculties.Add(new Faculty("Finki", 30, new List<Student> { Students[5], Students[1], Students[3], Students[2]}));
                Faculties.Add(new Faculty("Elektro", 20, new List<Student> { Students[1], Students[3], Students[4] }));
                Faculties.Add(new Faculty("Ekonomski", 15, new List<Student> { Students[0], Students[2], Students[3] }));
                Faculties.Add(new Faculty("Praven", 40, new List<Student> { Students[1], Students[3], Students[4] }));
                Faculties.Add(new Faculty("Medicina", 35, new List<Student> { Students[5], Students[1], Students[3], Students[2] }));
                Faculties.Add(new Faculty("Arhitektura", 25, new List<Student> { Students[0], Students[2], Students[3] }));

                Universities = new List<University>();
                Universities.Add(new University("UKIM", "Skopje", new List<Faculty> { Faculties[1], Faculties[2], Faculties[3] }));
                Universities.Add(new University("Goce ", "Skopje", new List<Faculty> { Faculties[0], Faculties[4], Faculties[5] }));
            }
        }
    }

