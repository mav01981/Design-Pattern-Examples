using Observer;
using System;

namespace Observer_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            TemperatureReporter provider = new TemperatureReporter();
            TemperatureMonitor monitor_Indoors= new TemperatureMonitor();
            TemperatureMonitor monitor_Outdoors = new TemperatureMonitor();

            monitor_Outdoors.Subscribe(provider);
            monitor_Outdoors.GetTemperature();

            Console.Read();
        }
    }
}
