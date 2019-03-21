using System;
using TestPatterns.Abstracts;

namespace TestPatterns.CocaCola
{
    public class CocaColaCover : AbstractCover
    {
        public string Name { get; set; } = "CocaCola";
        public override void PrintCoverName()
        {
            Console.WriteLine($"Cover is {this.Name}.");
        }
    }
}
