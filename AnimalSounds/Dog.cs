using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    public class Dog : IAnimalSounds
    {
           
        public string GetAnimalName()
        {
            return "dog";
        }

        public string GetAnimalSound()
        {
            return "ruff ruff";
        }

        public string ToPrint()
        {
            throw new NotImplementedException();
        }
    }
}
