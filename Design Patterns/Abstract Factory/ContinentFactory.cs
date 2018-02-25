namespace Abstract_Factory
{
    abstract class ContinentFactory
    {
        public abstract Carnivore CreateCarnivore();
        public abstract Hebivore CreateHebivore();
    }
}
