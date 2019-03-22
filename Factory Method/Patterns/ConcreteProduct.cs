using Factory_Method.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
