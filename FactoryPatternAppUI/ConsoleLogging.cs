using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FactoryPatternAppUI
{
    class ConsoleLogging
    {
        public static void VehicleStartupDialogue()
        {
            Console.WriteLine("1. Put the key in the ignition");
            Thread.Sleep(1000);
            Console.WriteLine("2. Turn it on");
            Thread.Sleep(1000);
        }
    }
}