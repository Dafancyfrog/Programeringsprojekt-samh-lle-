using System;
using System.Collections.Generic;
using System.Text;

namespace Programeringsprojekt_samhälle_
{
    class Company
    {
        public int Id { get; set; }

        public string Type { get; set; }
        public int Size { get; set; }
        public string Popularity { get; set; }
        public int NumOfEmployees { get; set; }
        public List<Employee> employees { get; set; } = new List<Employee>();


      
    }
}
