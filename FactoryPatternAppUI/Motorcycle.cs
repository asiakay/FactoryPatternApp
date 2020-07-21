using System;
namespace FactoryPatternAppUI
//classes must conform to IVehicle and
//todo implement the Drive() method 
{
    public class Motorcycle: IVehicle
    {
        public Motorcycle()
        {
        }
        public void Drive()
        {
            ConsoleLogging.VehicleStartupDialogue();
            Console.WriteLine("If you must live dangerously, please wear a helmet");
        }
    }
}
