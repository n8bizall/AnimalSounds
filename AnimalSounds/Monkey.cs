using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    public class Monkey : IAnimalSounds
    {
        public string GetAnimalName()
        {
            return "mokey";
        }

        public string GetAnimalSound()
        {
            return "ohoh ahah";
        }

        public string ToPrint()
        {
            throw new NotImplementedException();
        }
    }
}
