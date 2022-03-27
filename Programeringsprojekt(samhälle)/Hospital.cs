using System;
using System.Collections.Generic;
using System.Text;

namespace Programeringsprojekt_samhälle_
{
    class Hospital : Emergencyservice
    {
        public static int amountOfHospitals { get; set; } = 0;
        public int Id { get; set; }
        public int Ambulance { get; set; }
        public List<Hospital> hospitals { get; set; } = new List<Hospital>();

        public void StartWork(Employee employyeObj)
        {

        }
        public Hospital(string aname, int aambulance, string atype, int anumberOfPatients)
        {
            amountOfHospitals++;
            this.Id = amountOfHospitals;
            this.Name = aname;
            this.Ambulance = aambulance;
            this.Type = atype;
            this.NumberOfPatients = anumberOfPatients;
        }
    }
}
