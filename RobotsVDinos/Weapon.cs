﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVDinos
{
    internal class Weapon
    {
        string Type { get; set; }
        int AttackPower { get; set; }
        public Weapon(string type, int attackPower)
        {
            Type = type;
            AttackPower = attackPower;
        }
    }
}
