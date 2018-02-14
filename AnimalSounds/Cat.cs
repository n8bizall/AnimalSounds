using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    public class Cat : IAnimalSounds
    {
        public string GetAnimalName()
        {
            return "cat";
        }

        public string GetAnimalSound()
        {
            return "meow mix";
        }

        public string ToPrint()
        {
            throw new NotImplementedException();
        }
    }
}
