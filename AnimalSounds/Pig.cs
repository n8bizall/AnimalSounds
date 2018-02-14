using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    public class Pig : Isounds
    {
        public string GetName()
        {
            return "pig";
        }

        public string GetSound()
        {
            return "oink oink oink";
        }

        public string ToPrint()
        {
            throw new NotImplementedException();
        }
    }
}
