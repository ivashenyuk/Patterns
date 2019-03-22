using System;

namespace Builder.Houses
{
    public class Storey
    {
        public string Name { get; } = "Storey";
        public Storey()
        {
            Console.WriteLine($"{this.Name} is done.");
        }
    }
}
