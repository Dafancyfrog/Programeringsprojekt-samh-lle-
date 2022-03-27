using System;
using System.Collections.Generic;
using System.Text;

namespace Programeringsprojekt_samhälle_
{
    class Entertainment : Company
    {

        public static int amountOfEntertainment { get; set; } = 0;
        public string Location { get; set; }
        public string Name { get; set; }
        public string Activity { get; set; }


        public void StartWork(Employee employyeObj)
        {

        }
        public Entertainment(string aLocation, string aName, string aActivity)
        {
            amountOfEntertainment++;
            this.Id = amountOfEntertainment;
            this.Location = aLocation;
            this.Name = aName;
            this.Activity = aActivity;
        }


    }

}