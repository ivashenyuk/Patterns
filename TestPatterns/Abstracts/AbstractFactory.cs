namespace TestPatterns.Abstracts
{
    public abstract class AbstractFactory
    {
        public abstract AbstractBottle CreateBottle();
        public abstract AbstractCover CreateCover();
        public abstract AbstractLable CreateLable();
        public abstract AbstractWater CreateWater();
    }
}
