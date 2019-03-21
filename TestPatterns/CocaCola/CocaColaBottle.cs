using System;
using TestPatterns.Abstracts;

namespace TestPatterns.CocaCola
{
    public class CocaColaBottle : AbstractBottle
    {
        public string Name { get; set; } = "CocaCola";

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
