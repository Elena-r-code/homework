using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Classes
{
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool Driving { get; set; }
        public string Email { get; set; }
        public DateTime DateOfEnrollment { get; set; }
        public long EMBG { get; set; }
        public TypeOfStudent TypeOfStudent { get; set; }
        public string MartialStatus { get; set; }
        public DateTime DateGraduated { get; set; }
        

        public Student(string name, string surname, bool driving, string email, DateTime dateofenrollment, long embg, TypeOfStudent typeOfStudent, string martialstatus, DateTime dategraduated)
        {
            Name = name;
            Surname = surname;
            Driving = driving;
            Email = email;
            DateOfEnrollment = dateofenrollment;
            EMBG = embg;
            TypeOfStudent = typeOfStudent;
            MartialStatus = martialstatus;
            DateGraduated = dategraduated;
            
        }
    }
}
