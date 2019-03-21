namespace TestPatterns.Abstracts
{
    public abstract class AbstractBottle
    {
        public abstract void PrintWaterName();
        public abstract void Interact(AbstractWater abstractWater,
            AbstractCover abstractCover,
            AbstractLable abstractLable);
    }
}
