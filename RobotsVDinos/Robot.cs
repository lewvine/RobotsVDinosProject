﻿using System;
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

        public Robot(string name, Weapon weapon)
        {
            Name = name;
            Health = 100;
            PowerLevel = 100;
            Weapon = weapon;
            AttackPower = weapon.AttackPower;
        }

        public void Attack(Dinosaur dino)
        {
            Console.WriteLine(Name + "'s turn to attack.");
            Console.WriteLine("ATTACK NOW!  (Press ENTER to attack");
            Console.ReadLine();
            Console.WriteLine(Name + " attacks with " + Weapon.Type + ".  Inflicts " + AttackPower + " damage!");
            PowerLevel -= 10;
            dino.Health -= AttackPower;
        }
    }
}
