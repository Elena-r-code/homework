using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Classes
{
    public class University
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public List<Faculty> Faculties { get; set; }
        public University(string name, string location, List<Faculty> faculties)
        {
            Name = name;
            Location = location;
            Faculties = faculties;
    }
    }
    
}
