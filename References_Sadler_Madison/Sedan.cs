// System namespace needed to use Console class
using System;
// System.Collections.Generic namespace needed to use Console class
using System.Collections.Generic;
// System.Linq namespace needed to use Console class
using System.Linq;
// System.Text namespace needed to use Console class
using System.Text;
// System.Threading.Tasks namespace needed to use Console class
using System.Threading.Tasks;

// My collection of classes for this project
namespace References_Sadler_Madison
{
    // Creates a class called Sedan and implements interface IAutomobile
    internal class Sedan : IAutomobile
    {
        // Declares a public double called Speed with an automatic getter and private setter
        public double Speed { get; private set; }

        // Declares a public integer called Wheels with an automatic getter and private setter
        public int Wheels { get; private set; }

        // Declares a public string called LicensePlate with an automatic getter and private setter
        public string LicensePlate { get; private set; }

        // Creates a constructor called Sedan that takes a double parameter called speed
        // Sets Wheels to 4, Speed to speed, and LicensePlate to GCTC-06
        public Sedan(double speed) { Wheels = 4; Speed = speed; LicensePlate = "GCTC-06"; }

        // Creates a public void method called Stringify()
        public void Stringify()
        {
            // Prints to console that the truck is traveling at a speed it is set to on the amount of wheels it is set to with a License Plate # it is set to
            Console.WriteLine($"The Sedan is traveling at a speed of {Speed} on {Wheels} wheels, with a License Plate # of {LicensePlate}.");
        }

        // Implements a public void method called IncreaseSpeed() that increases the speed by 5 when called
        public void IncreaseSpeed()
        {
            Speed += 5;
        }

        // Implements a public void method called DecreaseSpeed() that decreases the speed by 5 when called
        public void DecreaseSpeed()
        {
            Speed -= 5;
        }

    }
}
