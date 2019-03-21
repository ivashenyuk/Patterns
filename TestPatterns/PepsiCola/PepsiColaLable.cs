using System;
using TestPatterns.Abstracts;

namespace TestPatterns.PepsiCola
{
    public class PepsiColaLable : AbstractLable
    {
        public string Name { get; set; } = "PepsiCola";
        public override void PrintLableName()
        {
            Console.WriteLine($"Lable is {this.Name}.");
        }
    }
}
