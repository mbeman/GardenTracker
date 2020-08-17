using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenTracker.Model
{
    public class Plant
    {
        public Plant(int gestation, DateTime plantDate, string name, int seeds, string notes)
        {
            Gestation = gestation;
            PlantDate = plantDate;
            Name = name;
            SeedsPerSquare = seeds;
            Notes = notes;
        }

        public int Gestation { get; }
        
        public string Name { get; }

        public string Notes { get; set; }

        public int SeedsPerSquare { get; }

        public DateTime PlantDate { get; }
    }
}
