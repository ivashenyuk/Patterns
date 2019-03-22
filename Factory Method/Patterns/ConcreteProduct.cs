using Factory_Method.Abstracts;
using System;

namespace Factory_Method
{
    public class ConcreteProduct : Product
    {
        public string Name { get; set; } = "Concrete Product";
        public ConcreteProduct()
        {
            Console.WriteLine($"{this.Name} : {base.Name} |  {this.GetHashCode()}");
        }
    }
}
