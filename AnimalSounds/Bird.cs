using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    public class Bird : IAnimalSounds
    {
        public string GetAnimalName()
        {
            return "bird";
        }

        public string GetAnimalSound()
        {
            return "poly want a cracker";
        }

        public string ToPrint()
        {
            throw new NotImplementedException();
        }
    }
}
