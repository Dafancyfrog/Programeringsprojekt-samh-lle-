using System;
using System.Collections.Generic;
using System.Text;

namespace Programeringsprojekt_samhälle_
{
    class FireStation : Emergencyservice
    {
        public int FireTrucks { get; set; }

        public string name { get; set; }

        public int Id { get; set; }
        public static int amountOfFirestations { get; set; } = 0;


        public void ComeToWork(Employee employeeObj)
        {

        }
        public FireStation(string aname,string aType, int aNumberOfPatients, int aFireTrucks)
        {
            amountOfFirestations++;
            this.Id = amountOfFirestations;
            this.name = aname;
            this.Type = aType;
            this.NumberOfPatients = aNumberOfPatients;
            this.FireTrucks = aFireTrucks;
        }
    }
}
