using Factory_Method.Abstracts;
using System;

namespace Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator creator = new ConcreteCreator();
            Product product = creator.FactoryMethod();

            creator.AnOperation();

            Console.ReadLine();
        }
    }
}
