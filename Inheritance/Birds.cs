using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Birds
    {
        public string Color { get; set; }
        public bool HasFeathers { get; set; }
        public int Wings { get; set; }
        public bool CanFly { get; set; }

        public Bird()
        {

        }

        public Bird(string color, int wings, bool hasFeathers, bool canFly, string type)
        {
            Wings = wings;
            Color = color;
            HasFeathers = hasFeathers;
            CanFly = canFly;

        }
    }

}
