using System;
using TestPatterns.Abstracts;

namespace TestPatterns.PepsiCola
{
    public class PepsiColaBottle : AbstractBottle
    {
        public string Name { get; set; } = "PepsiCola";

        public override void Interact(AbstractWater abstractWater, AbstractCover abstractCover, AbstractLable abstractLable)
        {
            abstractWater.PrintWaterName();
            abstractCover.PrintCoverName();
            abstractLable.PrintLableName();
            this.PrintWaterName();
        }

        public override void PrintWaterName()
        {
            Console.WriteLine($"Bottle is {this.Name}.");
        }
    }
}
