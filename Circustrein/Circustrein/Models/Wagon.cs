using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    public class Wagon
    {

        //Properties
        public List<Animal> Animals { get; set; }

        public int FreePoints { get; set; }

        //Constructor
        public Wagon()
        {
            Animals = new List<Animal>();
            FreePoints = 10;
        }

        

    }
}
