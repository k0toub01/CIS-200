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
    class GroundPackage : Package //Child class to package
    {
        public GroundPackage(Address originAddress, Address destAddress, double length, double width,
    double height, double weight)
    : base(originAddress, destAddress, length, width, height, weight) //derived from superclass
        {
            
        }

        public int ZoneDistance //read only
        {
            get
            {
                int zoneDiff = 10000;

                 int totalDistance = ((OriginAddress.Zip / zoneDiff) - (DestinationAddress.Zip / zoneDiff));

                return Math.Abs(totalDistance); //using math.abs to have a positive num

            }
        }
        public override decimal CalcCost()
        {
            return (decimal)(.15 * (Length+Height+Weight)+.7 *(ZoneDistance+1)*(Weight)); //cost of the package
        }
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            return $"Ground Delivery {NL}{base.ToString()}\n Zone Distance: {ZoneDistance}";
        }
    }
}
