﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    public class Tiger : Isounds
    {
        public string GetName()
        {
            return "tiger";
        }
        public string GetSound()
        {
            return "Who Dey";
        }

        public string ToPrint()
        {
            throw new NotImplementedException();
        }
    }
}
