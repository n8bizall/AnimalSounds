using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    public class Chicken : Isounds
    {
        public string GetName()
        {
            return "chicken";
        }

        public string GetSound()
        {
            return "bawk bawk bawk";
        }

        public string ToPrint()
        {
            throw new NotImplementedException();
        }
    }
}
