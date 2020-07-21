using System;
namespace FactoryPatternAppUI
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int WheelNumber)
        {
            switch(WheelNumber)
            {
                case 2:
                    return new Motorcycle();
                case 3:
                    return new Tricycle();
                case 4:
                    return new Car();
                default:
                    return new Car();

            }
            
        }
    }
}
