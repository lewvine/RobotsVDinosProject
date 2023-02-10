using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVDinos
{
    internal class Dinosaur
    {
        //Fields
        public string Type { get; set; }
        public int Health { get; set; }
        public int Energy { get; set; }
        public int AttackPower { get; set; }

        public Dinosaur(string type)
        {
            Type = type;
            Health = 100;
            Energy = 100;
            AttackPower = 7;
        }

        public void Attack(Robot robot)
        {
            Console.WriteLine(Type + "'s turn to attack.");
            Console.WriteLine(Type + " attacks!  Inflicts " + AttackPower + " damage!");
            Energy -= 10;
            robot.Health -= AttackPower;
        }
    }
}
