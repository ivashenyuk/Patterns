using System;
using TestPatterns.Abstracts;

namespace TestPatterns.CocaCola
{
    public class CocaColaWater : AbstractWater
    {
        public string Name { get; set; } = "CocaCola";
        public override void PrintWaterName()
        {
            Console.WriteLine($"Water is {this.Name}.");
        }
    }
}
