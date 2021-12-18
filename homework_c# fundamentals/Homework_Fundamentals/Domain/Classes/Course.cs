using Domain.Enums;
using System.Collections.Generic;

namespace Domain.Classes
{
    public class Course
    {
        public string Code { get; set; }
        public string NameOfCourse { get; set; }
        public int Credits { get; set; }
        public TypeOfCourse TypeOfCourse { get; set; }
        public Language Language { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
        public Course(string code, string nameofcourse, int credits, List<Student> students)
        {
            Code = code;
            NameOfCourse = nameofcourse;
            Credits = credits;
            Students = students;
           
        }
    }
}
