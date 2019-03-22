using Factory_Method.Abstracts;
using System;

namespace Factory_Method
{
    public class ConcreteCreator : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProduct();
        }
    }
}
