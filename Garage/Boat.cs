using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    internal class Boat : Vehicle
    {

        public double Lenght { get;  }

        public Boat(int numberOfWheels, string registrationNumber, string color, string lenght)
               : base(numberOfWheels, registrationNumber, color)
        {
            if (Utility.IsNumeric(lenght))
                Lenght = double.Parse(lenght);
            else Menus.InvalidMessage();
            
        }
        public override string ToString()
        {
            return base.ToString() + $"Längd: {Lenght}";
        }
    }
}
