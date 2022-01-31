﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Interfaces
{
    class Club : IMleeWeapon, IRepairible
    {
        public int durability;
        public int Damage { get => 6; set => throw new NotImplementedException(); }
        public int AttackSpeed { get => 4; set => throw new NotImplementedException(); }
        int IRepairible.durability { get => durability; set => durability = value; }

        public void Hit()
        {
            Console.WriteLine($"Club makes 'tuk-tuk' with {Damage} and {AttackSpeed} ");
        }
    }
}
