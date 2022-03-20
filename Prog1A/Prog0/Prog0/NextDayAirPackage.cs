using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    class NextDayAirPackage : AirPackage
    {
        private decimal _expressFee; //backing field
        public NextDayAirPackage(Address originAddress, Address destAddress, double length, double width,
        double height, double weight, decimal expressFee)
        : base(originAddress, destAddress, length, width, height, weight)
        {
            ExpressFee = expressFee; 
        }

        public decimal ExpressFee 
        {
            // Precondition:  None
            // Postcondition: The NDAP ExpressFee has been returned
            get
            { 
                return _expressFee; 
            }

            // Precondition:  value must not be null
            // Postcondition: The NDAP express fee has been set to the
            //                specified value
            private set
            {
                if (value >= 0)
                    _expressFee = value;
                else
                    throw new ArgumentOutOfRangeException(nameof(value), value,
                        $"{nameof(value)} must be greater than or equal to 0");
            }
        }


        public override decimal CalcCost()
        {
            double height = .35;
            double weight = .25;
            double heavyPackage = .20;
            double largePackage = .20;
            
            decimal baseCost = (decimal)(height * (Length + Width + Height) + weight*(Weight)) + ExpressFee;
            decimal weightCharge = (decimal) (heavyPackage * Weight);
            decimal largeCharge = (decimal)(largePackage * (Length+Width+height));

            if (IsHeavy())
                return baseCost += weightCharge;
            if (IsLarge())
                return baseCost += largeCharge;
            else
                return baseCost;  
        }
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            return $"Next Day Air Package;{NL}{base.ToString()}{NL}Express Fee: {ExpressFee:C2}";
        }
    }
}
