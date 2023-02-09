using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVDinos
{
    internal class Herd
    {
        public List<Dinosaur> dinosaurs { get; set; }

        public Herd()
        {
            dinosaurs = new List<Dinosaur>();
        }
    }
}
