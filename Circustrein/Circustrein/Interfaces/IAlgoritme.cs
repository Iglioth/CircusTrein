using Circustrein.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein.Interfaces
{
    public interface IAlgoritme
    {
        bool WagonHasMeatEater(Wagon w);
        Animal WagonMeatEater(Wagon w);
        bool AnimalToAddIsSmallest(Wagon w, Animal a);
        bool WagonHasRoom(Wagon w, Animal a);
    }
}
