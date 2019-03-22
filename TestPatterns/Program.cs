using System;
using TestPatterns.CocaCola;
using TestPatterns.PepsiCola;

namespace TestPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var clientCocaCola = new Client(new CocaColaFactory());
            clientCocaCola.Run();

            Console.WriteLine();

            var clientPepsiCola = new Client(new PepsiColaFactory());
            clientPepsiCola.Run();

            Console.ReadLine();
        }
    }
}
