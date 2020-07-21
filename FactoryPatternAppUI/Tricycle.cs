using System;
namespace FactoryPatternAppUI
//classes must conform to IVehicle and
//todo implement the Drive() method 
{
    public class Tricycle: IVehicle
    {
        public Tricycle()
        {
        }
        public void Drive()
        {
            ConsoleLogging.VehicleStartupDialogue();
            Console.WriteLine("What are you a toddler? LOL");
        }

    }
}
