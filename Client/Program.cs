
using System;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            //Abstract Factorys.
            var nokiaFactory= new Nokia();
            var samsungFactory = new Samsung();

            var nokiaClient = new MobileClient(nokiaFactory);
            var samsungClient = new MobileClient(samsungFactory);

            Console.WriteLine(samsungClient.GetSmartPhoneModelDetails());
            Console.WriteLine(nokiaClient.GetSmartPhoneModelDetails());
            Console.ReadLine();
        }
    }
}
