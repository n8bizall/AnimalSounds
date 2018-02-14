using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    public class Bird : Isounds
    {
        public string GetName()
        {
            return "bird";
        }

        public string GetSound()
        {
            return "poly want a cracker";
        }

        public string ToPrint()
        {
            throw new NotImplementedException();
        }
    }
}
