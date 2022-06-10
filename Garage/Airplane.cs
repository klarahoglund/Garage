using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    internal class Airplane : Vehicle
    {
        public int NumberOfEngines { get;}

        public Airplane (int numberOfWheels, string registrationNumber, string color, string numberOfEngines)
                : base(numberOfWheels, registrationNumber, color)
            {
            if (Utility.IsNumeric(numberOfEngines))
                NumberOfEngines = int.Parse(numberOfEngines);
            else Menus.InvalidMessage();
          
            }

        public override string ToString()
        {
            return base.ToString() + $" Antal motorer: {NumberOfEngines}";

        }
    }
}
