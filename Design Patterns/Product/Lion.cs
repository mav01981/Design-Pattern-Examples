
using System;

namespace Abstract_Factory
{
    class Lion : Carnivore
    {
        public override void Eat(Hebivore herbivore)
        {
            Console.WriteLine("{0} Eats {1}" + this.GetType().Name, herbivore.GetType().Name);
        }
    }
}
