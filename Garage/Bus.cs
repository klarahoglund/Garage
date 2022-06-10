using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    internal class Bus : Vehicle
    {
        public int NumberOfSeats { get;  }
        public Bus(int numberOfWheels, string registrationNumber, string color, string numberOfSeats) 
                : base(numberOfWheels, registrationNumber, color)
        {
            // convertera nrOfSeats till int
            if (Utility.IsNumeric(numberOfSeats))
                NumberOfSeats = int.Parse(numberOfSeats);
            else Menus.InvalidMessage();
        }
        public override string ToString()
        {
            return base.ToString() + $"Antal sittplatser: { NumberOfSeats}";
        }
       
    }
}

