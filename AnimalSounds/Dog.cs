using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    public class Dog : Isounds
    {
           
        public string GetName()
        {
            return "dog";
        }

        public string GetSound()
        {
            return "ruff ruff";
        }

        public string ToPrint()
        {
            throw new NotImplementedException();
        }
    }
}
