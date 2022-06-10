using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    internal class Motorcycle : Vehicle
    {
        public int CylinderVolume { get; }


        public Motorcycle(int numberOfWheels, string registrationNumber, string color, string cylinderVolume)
                : base(numberOfWheels, registrationNumber, color)
        {
            if (Utility.IsNumeric(cylinderVolume))
                CylinderVolume = int.Parse(cylinderVolume);
            else Menus.InvalidMessage();
            
        }
        public override string ToString()
        {
            return base.ToString() + $"CC: {CylinderVolume}";
        }
    }
}
