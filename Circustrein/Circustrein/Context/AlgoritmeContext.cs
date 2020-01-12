using Circustrein.Interfaces;
using Circustrein.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein.Context
{
    public class AlgoritmeContext : IAlgoritme
    {

        //Returns whether the Wagon contains a meateater
        public bool WagonHasMeatEater(Wagon w)
        {
            if (w.Animals.Exists(a => a.Eater != AnimalType.Herbivore))
            {
                return true;
            }
            return false;
        }

        //Returns the carnivore from the wagon, if there is any.
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

        //Returns whether the Animal is the smallest out of the ones that are already in the wagon
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

        //Returns whether the wagon still has room
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
    }
}
