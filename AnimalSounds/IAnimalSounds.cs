﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    public interface IAnimalSounds
    {
        string GetAnimalName();
        string GetAnimalSound();
        string ToPrint();
    }
}
