using System;
//classes must conform to IVehicle and
//todo implement the Drive() method 

namespace FactoryPatternAppUI
{
    public class Car : IVehicle
    {
        public Car()
        { 
        }
     public void Drive()
        {
            ConsoleLogging.VehicleStartupDialogue();
            Console.WriteLine("Beep Beep. You got the Keys to the Jeep.");
            Console.WriteLine("Vrooooooom");

        }
    }
}
