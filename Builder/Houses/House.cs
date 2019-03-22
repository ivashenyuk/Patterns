using System.Collections;

namespace Builder.Houses
{
    public class House
    {
        private ArrayList _parts = new ArrayList();

        public void Add(object obj)
        {
            this._parts.Add(obj);
        }
    }
}
