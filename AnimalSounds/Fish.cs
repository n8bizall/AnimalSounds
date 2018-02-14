using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    public class Fish : IAnimalSounds
    {
        public string GetAnimalName()
        {
            return "fish";
        }

        public string GetAnimalSound()
        {
            return "bubble bubble";
        }

        public string ToPrint()
        {
            throw new NotImplementedException();
        }
    }
}
