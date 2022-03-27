using System;
using System.Collections.Generic;
using System.Text;

namespace Programeringsprojekt_samhälle_
{
    class Store : Company
    {
        public string location { get; set; }

        public static int amountOfStores { get; set; } = 0;


        public Store (int asize, string atype, string alocation)
        {
            amountOfStores++;
            this.Id = amountOfStores;
            this.Size =  asize;
            this.Type = atype;
            this.location = alocation;

        }

        public void StartWork(Employee employyeObj)
        {

        }

    }
}
