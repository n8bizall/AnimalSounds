using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    public class Pig : IAnimalSounds
    {
        public string GetAnimalName()
        {
            return "pig";
        }

        public string GetAnimalSound()
        {
            return "oink oink oink";
        }

        public string ToPrint()
        {
            throw new NotImplementedException();
        }
    }
}
