using System;
using System.Collections.Generic;
using System.Text;

namespace Programeringsprojekt_samhälle_
{
    class Emergencyservice 
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int NumberOfPatients { get; set; }
        public List<Employee> employees { get; set; } = new List<Employee>();
    }
}
