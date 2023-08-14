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
    // Creates an interface called IAutomobile
    internal interface IAutomobile
    {
        // Declares a public double called Speed with an automatic getter
        public double Speed { get; }
        // Declares a public integer called Wheels with an automatic getter
        public int Wheels { get; }
        // Declares a public string called LicensePlate with an automatic getter
        public string LicensePlate { get; }
        // Defines a public void method called Stringify()
        public void Stringify();
    }
}
