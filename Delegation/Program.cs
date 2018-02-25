using System;

namespace Delegation
{
    class Program
    {
        delegate void Print(int value);

        static void Main(string[] args)
        {

            Print print = PrintNumber;
            print(100000);
            print(200);

            print = PrintMoney;
            print(10);

            //Multi Casting
            Print printnumber = new Print(PrintNumber);
            Print printmoney = new Print(PrintMoney);
            printnumber += printmoney;

            printnumber(100000);

            Console.ReadLine();
        }

        public static void PrintNumber(int num)
        {
            Console.WriteLine("Number: {0,-12:N0}", num);
        }

        public static void PrintMoney(int money)
        {
            Console.WriteLine("Money: {0:C}", money);
        }
    }
}
