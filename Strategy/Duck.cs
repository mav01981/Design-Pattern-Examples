namespace Strategy
{
    public class Duck
    {
        private IQauckbehaviour _strategy;

        public Duck(IQauckbehaviour strategy)
        {
            this._strategy = strategy;
        }

        public string Quack()
        {
            return _strategy.Quack();
        }
    }
}
