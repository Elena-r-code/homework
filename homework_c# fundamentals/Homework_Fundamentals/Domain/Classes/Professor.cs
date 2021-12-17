using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Classes
{
    public class Professor
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public List<Course> Courses { get; set; }
        public Professor(string name, string surname, string email, List<Course> courses)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Courses = courses;
        }
    }
}
