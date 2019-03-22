using Builder.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
