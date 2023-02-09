using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVDinos
{
    internal class Fleet
    {
        public List<Robot> robots { get; set; }

        public Fleet()
        {
            robots = new List<Robot>();
        }
    }
}
