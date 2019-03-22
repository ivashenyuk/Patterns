using Builder.Abstracts;

namespace Builder
{
    public class Foreman
    {
        private AbstractBuilder _builder;

        public Foreman(AbstractBuilder builder)
        {
            this._builder = builder;
        }

        public void Construct()
        {
            this._builder.BuildBasemant();
            this._builder.BuildStorey();
            this._builder.BuildRoof();
        }
        //public void Show()
        //{
        //    foreach (var part in this.parts)
        //    {
        //        Console.WriteLine(part);
        //    }
        //}
    }
}
