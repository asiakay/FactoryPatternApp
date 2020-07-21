using System;
using System.Collections.Generic;
using System.Linq;

// done
//todo Create a new console app that utilizes factory pattern
// Create an Interface named IVehicle
// stub out public void Drive method
//todo take a user’s input of how many tires are on a vehicle
//todo based on their input, create that type of vehicle.
//todo Complete this using both an interface and an abstract class.

//todo Create 2 new classes that will conform to IVehicle
//todo have at least 3 subclasses.

//Example) Car, Motorcycle, BigRig
//Complete this using both an interface and an abstract class.
//You must have at least 3 subclasses.
//For instance, if I type 4 into the console,



//todo classes must conform to IVehicle and
//todo implement the Drive() method 
//todo Console.WriteLine(“Building a new Car!”)
//todo
//todo //Now we will make our static VehicleFactory class
//todo
//todo//It will contain a static method GetVehicle(), that will
//todo return an IVehicle
//todo base IVehicle on the amount of tires as given Parameter parameter
//todo Call this functionality in the Main method
//For instance, if I type 4 into the console,
//the program would create a car or truck,
//or if someone types 2 it would create a motorcycle.

namespace FactoryPatternAppUI
{
    class Program
    {
        public static void Main(string[] args)
        {
            int wheelCount;
            bool input = false;
            // why does wheelCount not have a value

            do
            {
                Console.WriteLine("How many tires would you like on your vehicle?");


                input = int.TryParse(Console.ReadLine(), out wheelCount);
                            //placing the Console.Readline inside of the
                            //TryParse method because we want the
                            //string input from the user to be converted
                            // to datatype int for processing in our
                            //vehicle factory
                            //bool input = false because there is no user input yet
                            //when user inputs the number, bool input becomes true
            } while (input == false);
            var vehicle = VehicleFactory.GetVehicle(wheelCount);
            //referencing the factory, which is a static class
            //creating a new vehicle from this method
            vehicle.Drive();
            //calling the Drive() method using . notation via the
            //local variable var = vehicle.
            

            //int typeByWheel;
            //Console.WriteLine("How many tires would you like on your vehicle?");
            //var vehicle = VehicleFactory.GetVehicle(typeByWheel);
            //var userInput = int.TryParse(Console.ReadLine(),out vehicle);
            //Console.WriteLine(typeByWheel);
        }
    }
}
