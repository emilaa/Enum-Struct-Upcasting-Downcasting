using System;
using System.Collections.Generic;
using System.Text;

namespace Enum__Struct__Upcasting__Downcasting.Models
{
    public class Shark : Fish
    {
        public int Weight { get; set; } = 50;
        public override void Eat()
        {
            Console.WriteLine("Shark eating");
        }
    }
}
