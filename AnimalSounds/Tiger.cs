using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    public class Tiger : IAnimalSounds
    {
        public string GetAnimalName()
        {
            return "tiger";
        }
        public string GetAnimalSound()
        {
            return "Who Dey";
        }

        public string ToPrint()
        {
            throw new NotImplementedException();
        }
    }
}
