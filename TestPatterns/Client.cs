using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestPatterns.Abstracts;

namespace TestPatterns
{
    public class Client
    {
        AbstractBottle abstractBottle;
        AbstractCover abstractCover;
        AbstractLable abstractLable;
        AbstractWater abstractWater;

        public Client(AbstractFactory abstractFactory)
        {
            this.abstractBottle = abstractFactory.CreateBottle();
            this.abstractCover = abstractFactory.CreateCover();
            this.abstractLable = abstractFactory.CreateLable();
            this.abstractWater = abstractFactory.CreateWater();
        }

        public void Run()
        {
            this.abstractBottle.Interact(this.abstractWater, 
                this.abstractCover, 
                this.abstractLable);
        }
    }
}
