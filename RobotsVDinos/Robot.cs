using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVDinos
{
    internal class Robot
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int PowerLevel { get; set; }
        public Weapon Weapon { get; set; }
        public int AttackPower { get; set; }

        public Robot(string name, int health, int powerLevel, Weapon weapon, int attackPower)
        {
            Name = name;
            Health = health;
            PowerLevel = powerLevel;
            Weapon = weapon;
            AttackPower = attackPower;
        }
    }
}
