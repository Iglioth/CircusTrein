using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    public class Animal
    {

        //Properties
        public AnimalSize Size { get; set; }
        public AnimalType Eater { get; set; }
        public int points { get; set; }

        //Constructor
        public Animal(AnimalSize size, AnimalType eater, int points)
        {

            Size = size;
            Eater = eater;
            this.points = points;
        }



    }
}
