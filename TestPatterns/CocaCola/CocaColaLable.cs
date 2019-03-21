using System;
using TestPatterns.Abstracts;

namespace TestPatterns.CocaCola
{
    public class CocaColaLable : AbstractLable
    {
        public string Name { get; set; } = "CocaCola";
        public override void PrintLableName()
        {
            Console.WriteLine($"Lable is {this.Name}.");
        }
    }
}
