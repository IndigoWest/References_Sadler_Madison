// See https://aka.ms/new-console-template for more information

// My collection of classes for this project that is needed to use Console class
using References_Sadler_Madison;

// Creates a new Sedan object called myFirstSedan and sets to a speed of 0
Sedan myFirstSedan = new Sedan(0);
// Declares an IAutomobile object called myAutomobile and assigns it to myFirstSedan
IAutomobile myAutomobile = myFirstSedan;

// Creates a new Sedan object called myOtherSedan and sets to a speed of 0
Sedan myOtherSedan = new Sedan(0);

// Calls IncreaseSpeed() for myFirstSedan
myFirstSedan.IncreaseSpeed();
// Prints speed of myFirstSedan
Console.WriteLine(myFirstSedan.Speed);
// Prints speed of myAutomobile
Console.WriteLine(myAutomobile.Speed);
// Prints the comparison of the speeds of myAutomobile and myFirstSedan
Console.WriteLine(myFirstSedan.Equals(myAutomobile));

// Calls IncreaseSpeed() for myOtherSedan
myOtherSedan.IncreaseSpeed();
// Prints speed of myFirstSedan
Console.WriteLine(myFirstSedan.Speed);
// Prints speed of myOtherSedan
Console.WriteLine(myOtherSedan.Speed);
// Prints the comparison of the speeds of myFirstSedan and myOtherSedan
Console.WriteLine(myFirstSedan.Equals(myOtherSedan));

// Creates a new Truck object called myTruck and sets to a speed of 50, a weight of 500, and a license plate number of MyTrUcK
Truck myTruck = new Truck(50, 500, "MyTrUcK");

// Calls stringify method for myFirstSedan, myAutomobile, myOtherSedan, and myTruck
myFirstSedan.Stringify();
myAutomobile.Stringify();
myOtherSedan.Stringify();
myTruck.Stringify();