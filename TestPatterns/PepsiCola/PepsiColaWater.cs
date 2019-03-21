using System;
using TestPatterns.Abstracts;

namespace TestPatterns.PepsiCola
{
    public class PepsiColaWater : AbstractWater
    {
        public string Name { get; set; } = "PepsiCola";
        public override void PrintWaterName()
        {
            Console.WriteLine($"Water is {this.Name}.");
        }
    }
}
