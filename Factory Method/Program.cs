using Factory_Method.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
