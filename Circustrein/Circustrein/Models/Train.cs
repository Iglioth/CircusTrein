using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein.Models
{
    public class Train
    {
        public List<Wagon> wagons { get; set; }

        public Train()
        {
            wagons = new List<Wagon>();
        }
    }
}

