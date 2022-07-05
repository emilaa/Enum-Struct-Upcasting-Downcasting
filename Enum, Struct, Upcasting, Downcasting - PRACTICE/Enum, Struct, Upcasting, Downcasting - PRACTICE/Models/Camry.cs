using System;
using System.Collections.Generic;
using System.Text;

namespace Enum__Struct__Upcasting__Downcasting___PRACTICE.Models
{
    public class Camry : Toyota
    {
        public string Color { get; set; } = "Black";
        public override void Speed()
        {
            Console.WriteLine("Camry is fast");
        }
    }
}
