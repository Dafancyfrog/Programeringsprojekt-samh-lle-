using System;
using System.Collections.Generic;
using System.Text;

namespace Programeringsprojekt_samhälle_
{
    class Government
    {
        public int Id { get; set; }
        public int Population { get; set; }
        public List<Citizen> citizens { get; set; } = new List<Citizen>();


        public Government(int aId, int apopulation)
        {
            this.Id = aId;
            this.Population = apopulation;
        }
    }
}
