

namespace Abstract_Factory
{
    class AfricaFactory : ContinentFactory
    {
        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }

        public override Hebivore CreateHebivore()
        {
            return new Zebra();
        }
    }
}
