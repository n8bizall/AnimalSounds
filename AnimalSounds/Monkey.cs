﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    public class Monkey : Isounds
    {
        public string GetName()
        {
            return "mokey";
        }

        public string GetSound()
        {
            return "ohoh ahah";
        }

        public string ToPrint()
        {
            throw new NotImplementedException();
        }
    }
}
