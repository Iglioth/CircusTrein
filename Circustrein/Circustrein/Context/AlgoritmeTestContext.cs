using Circustrein.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein.Context
{
    public class AlgoritmeTestContext : IAlgoritme
    {
        public bool AnimalToAddIsSmallest(Wagon w, Animal a)
        {
            foreach (Animal a2 in w.Animals)
            {
                if (a2.Size <= a.Size)
                {
                    return false;
                }
            }
            return true;
        }

        public bool WagonHasMeatEater(Wagon w)
        {
            if (w.Animals.Exists(a => a.Eater != AnimalType.Herbivore))
            {
                return true;
            }
            return false;
        }

        public bool WagonHasRoom(Wagon w, Animal a)
        {
            if (w.FreePoints >= a.points)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Animal WagonMeatEater(Wagon w)
        {
            foreach (Animal a in w.Animals)
            {
                if (a.Eater == AnimalType.Carnivore)
                {
                    return a;
                }
            }
            return null;
        }
    }
}
