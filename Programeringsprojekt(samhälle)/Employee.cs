using System;
using System.Collections.Generic;
using System.Text;

namespace Programeringsprojekt_samhälle_
{
    class Employee: Citizen
    {
        public string WorkPlace { get; set; }

        public Employee(int aId, string aName, string aAddress, string aOccupation, int aSalary, string aWorkPlace)
        {
            this.Id = aId;
            this.Name = aName;
            this.Address = aAddress;
            this.Occupation = aOccupation;
            this.Salary = aSalary;
            this.WorkPlace = aWorkPlace;
        }
    }
}
