using System;
using System.Collections.Generic;
using System.Text;

namespace Enum__Struct__Upcasting__Downcasting___PRACTICE.Models
{
    public class Sonata : Hyundai
    {
        public int HorsePower { get; set; } = 290;
        public override void Speed()
        {
            Console.WriteLine("Sonata is fast");
        }
    }
}
