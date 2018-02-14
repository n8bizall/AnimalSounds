using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    public class Chicken : IAnimalSounds
    {
        public string GetAnimalName()
        {
            return "chicken";
        }

        public string GetAnimalSound()
        {
            return "bawk bawk bawk";
        }

        public string ToPrint()
        {
            throw new NotImplementedException();
        }
    }
}
