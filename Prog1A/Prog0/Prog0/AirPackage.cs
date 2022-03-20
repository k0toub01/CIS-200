// Program 1A
// CIS 200-50
// Fall 2021
// Due: 9/23/2021
// Student ID: 5258426

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    abstract class  AirPackage : Package
    {
        public double HeavyAirPackage = 75; // If Package is Heavier than  75 lbs
        public double LargePackage = 100;  // If Packahe is larger than 100 inches
        public AirPackage(Address originAddress, Address destAddress, double length, double width,
                double height, double weight)
                : base(originAddress, destAddress, length, width, height, weight) // All this data is coming from the parent case
        {

        }
        public Boolean IsHeavy() //a Boolean for if the package is heavier than 75 lbs
        {
            if (Weight >= HeavyAirPackage) //if statement using the Weight Condition
                return true;
            else
                return false; 
        }
        public Boolean IsLarge() //A boolean for if the package is larger than 100 lbs
        {
            if (Length + Height + Width >= LargePackage)
                return true;
            else
                return false;
        }
        public override string ToString() //overriding this to the string 
        {
            string NL = Environment.NewLine; // NewLine shortcut

            return $"{NL}{base.ToString()}\nHeavy Package: {IsHeavy()}\nLarge Package: {IsLarge()}";
        }
    }
}
