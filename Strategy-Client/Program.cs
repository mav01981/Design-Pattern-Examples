using Strategy;
using System;

namespace Strategy_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck duck;

            duck = new Duck(new AmericanDuck());
            Console.WriteLine(duck.Quack());

            duck = new Duck(new AfricanDuck());
            Console.WriteLine(duck.Quack());

            duck = new Duck(new EnglishDuck());
            Console.WriteLine(duck.Quack());

            Console.ReadLine();

        }
    }
}
