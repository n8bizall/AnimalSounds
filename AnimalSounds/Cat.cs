using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    public class Cat : Isounds
    {
        public string GetName()
        {
            return "cat";
        }

        public string GetSound()
        {
            return "meow mix";
        }

        public string ToPrint()
        {
            throw new NotImplementedException();
        }
    }
}
