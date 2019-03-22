using System;

namespace Builder.Houses
{
    public class Roof
    {
        public string Name { get; } = "Roof";

        public Roof()
        {
            Console.WriteLine($"{this.Name} is done.");
        }
    }
}
