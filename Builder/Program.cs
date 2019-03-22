using Builder.Builders;
using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new HouseBuilder();
            var foreman = new Foreman(builder);
            foreman.Construct();

            var house = builder.GetResult();

            Console.ReadLine();
        }
    }
}
