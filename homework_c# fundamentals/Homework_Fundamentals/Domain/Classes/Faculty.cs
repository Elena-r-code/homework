using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Classes
{
    public class Faculty
    {
        public string Name { get; set; }
        public int MaxNumberOfStudents { get; set; }
        //public List<Professor> Professors { get; set; }
        public List<Student> Students { get; set; }

        public Faculty(string name, int maxnumberofstudents, List<Student> students)
        {
            Name = name;
            MaxNumberOfStudents = maxnumberofstudents;
            Students = students;
        }
        
    }
}
