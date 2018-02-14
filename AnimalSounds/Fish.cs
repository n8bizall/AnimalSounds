using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    public class Fish : Isounds
    {
        public string GetName()
        {
            return "fish";
        }

        public string GetSound()
        {
            return "bubble bubble";
        }

        public string ToPrint()
        {
            throw new NotImplementedException();
        }
    }
}
