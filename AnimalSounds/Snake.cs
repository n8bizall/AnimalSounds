﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    public class Snake : Isounds
    {
        public string GetName()
        {
            return "snake";
        }

        public string GetSound()
        {
            return "hiss hiss";
        }

        public string ToPrint()
        {
            throw new NotImplementedException();
        }
    }
}
