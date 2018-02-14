using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    public class BassDrum : Isounds

    {
        public string GetName()
        {
            return "bass drum";
        }

        public string GetSound()
        {
            return "boomboom";
        }

        public string ToPrint()
        {
            throw new NotImplementedException();
        }
    }
}
