using System;
using TestPatterns.Abstracts;

namespace TestPatterns.PepsiCola
{
    public class PepsiColaCover : AbstractCover
    {
        public string Name { get; set; } = "PepsiCola";
        public override void PrintCoverName()
        {
            Console.WriteLine($"Cover is {this.Name}.");
        }
    }
}
