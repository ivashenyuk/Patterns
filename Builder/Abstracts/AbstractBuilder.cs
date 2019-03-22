using Builder.Houses;

namespace Builder.Abstracts
{
    public abstract class AbstractBuilder
    {
        public abstract void BuildBasemant();
        public abstract void BuildRoof();
        public abstract void BuildStorey();
        public abstract House GetResult();
    }
}
