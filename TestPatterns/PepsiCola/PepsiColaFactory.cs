using TestPatterns.Abstracts;

namespace TestPatterns.PepsiCola
{
    public class PepsiColaFactory : AbstractFactory
    {
        public override AbstractBottle CreateBottle()
        {
            return new PepsiColaBottle();
        }

        public override AbstractCover CreateCover()
        {
            return new PepsiColaCover();
        }

        public override AbstractLable CreateLable()
        {
            return new PepsiColaLable();
        }

        public override AbstractWater CreateWater()
        {
            return new PepsiColaWater();
        }
    }
}
