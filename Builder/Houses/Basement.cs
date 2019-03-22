using System;

namespace Builder.Houses
{
    public class Basement
    {
        public string Name { get; } = "Basemant";

        public Basement()
        {
            Console.WriteLine($"{this.Name} is done.");
        }
    }
}
