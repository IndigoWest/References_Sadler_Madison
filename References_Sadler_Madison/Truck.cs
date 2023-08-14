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
    // Creates a class called Truck and implements interface IAutomobile
    internal class Truck : IAutomobile
    {
        // Declares a public double called Speed with an automatic getter and private setter
        public double Speed { get; private set; }

        // Declares a public integer called Wheels with an automatic getter and private setter
        public int Wheels { get; private set; }

        // Declares a public string called LicensePlate with an automatic getter and private setter
        public string LicensePlate { get; private set; }

        // Declares a public double called Weight with an automatic getter
        public double Weight { get; }

        // Creates a public constructor called truck that takes parameters speed, weight, and licenseNum
        public Truck(double speed, double weight, string licenseNum)
        {
            // Sets Speed to speed, Weight to weight, and LicensePlate to licenseNum
            Speed = speed;
            Weight = weight;
            LicensePlate = licenseNum;

            // Creates an if else statement that states if weight is less than 400, the wheels are set to 8; Else sets wheels to 12
            if (Weight < 400)
            {
                Wheels = 8;
            }
            else
            {
                Wheels = 12;
            }
        }

        // Creates a public void method called Stringify()
        public void Stringify()
        {
            // Prints to console that the truck is traveling at a speed it is set to on the amount of wheels it is set to with a License Plate # it is set to
            Console.WriteLine($"The Truck is traveling at a speed of {Speed} on {Wheels} wheels, with a License Plate # of {LicensePlate}");
        }

        // Implements public void method called IncreaseSpeed() which increases speed by 5
        public void IncreaseSpeed()
        {
            Speed += 5;
        }

        // Implements public void method called DecreaseSpeed() which decreases speed by 5
        public void DecreaseSpeed()
        {
            Speed -= 5;
        }

    }
}
