using System;
using System.Collections.Generic;
using System.Text;

namespace Programeringsprojekt_samhälle_
{
    class PoliceStation : Emergencyservice
    {
        public static int amountOfStations { get; set; } = 0;
        public int Id { get; set; }
        public int Policecars { get; set; }



        public PoliceStation(string alocation, int aPoliceCars,string atype, int anumberOfPrisoners)
        {
            amountOfStations++;
            this.Id = amountOfStations;
            this.Location = alocation;
            this.Policecars = aPoliceCars;
            this.Type = atype;
            this.NumberOfPatients = anumberOfPrisoners;
        }

    }
}
