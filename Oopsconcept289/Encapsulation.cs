﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oopsconcept289
{
    internal class Encapsulation
    {
        internal class A
        {
            private int atmPin;
            public int GetReturn()
            {
                return atmPin;
            }
            public void SetValue(int pin)
            {
                atmPin = pin;
            }
        }
    }
}

