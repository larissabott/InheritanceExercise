using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptiles : Animal
    {
        public Reptiles()
        {
        }

        public string DefenseMechanism { get; set; }
        public string Habitat { get; set; }
        public bool IsColdBlooded { get; set; }
        public bool HasScales { get: set; }
    }
}
