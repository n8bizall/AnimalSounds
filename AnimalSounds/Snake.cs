using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    public class Snake : IAnimalSounds
    {
        public string GetAnimalName()
        {
            return "snake";
        }

        public string GetAnimalSound()
        {
            return "hiss hiss";
        }

        public string ToPrint()
        {
            throw new NotImplementedException();
        }
    }
}
