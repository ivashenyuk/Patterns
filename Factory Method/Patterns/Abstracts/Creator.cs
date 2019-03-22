namespace Factory_Method.Abstracts
{
    public abstract class Creator
    {
        private Product _product;
        public abstract Product FactoryMethod();

        public void AnOperation()
        {
            this._product = this.FactoryMethod();
        }
    }
}
