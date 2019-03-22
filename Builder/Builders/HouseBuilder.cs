using Builder.Abstracts;
using Builder.Houses;

namespace Builder.Builders
{
    public class HouseBuilder : AbstractBuilder
    {
        private readonly House _house;

        public HouseBuilder()
        {
            this._house = new House();
        }

        public override void BuildBasemant()
        {
            this._house.Add(new Basement());
        }

        public override void BuildRoof()
        {
            this._house.Add(new Roof());
        }

        public override void BuildStorey()
        {
            this._house.Add(new Storey());
        }

        public override House GetResult()
        {
            return this._house;
        }
    }
}
