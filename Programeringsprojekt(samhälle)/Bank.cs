using System;
using System.Collections.Generic;
using System.Text;

namespace Programeringsprojekt_samhälle_
{
    class Bank : Company
    {
        public static int amountOfBanks { get; set; } = 0;
        public string currency { get; set; }

        public int NumberOfAccouts { get; set; }


        public void StartWork(Employee employyeObj)
        {

        }
        public Bank(string atypeOfBuilding, string acurrency, int anumberOfAccounts)
        {
            amountOfBanks++;
            this.Id = amountOfBanks;
            this.NumberOfAccouts = anumberOfAccounts;
            this.currency = acurrency;
        }
    }
}

