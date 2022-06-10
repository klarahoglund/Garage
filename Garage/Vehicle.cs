using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Base PRODUCT

namespace Garage
{
    public abstract class Vehicle
    {
        public int NumberOfWheels { get;  set; }
        public string RegistrationNumber { get;  set; }
        public string? Color { get;  set; }

        public Vehicle(int numberOfWheels, string registrationNumber, string color)
        {
            NumberOfWheels = numberOfWheels;
            RegistrationNumber = registrationNumber;
            Color = color;
        }

        public override string ToString()
        {
            return $"Typ: {this.GetType().Name} \nRegistreringsnummer: { RegistrationNumber} \nFärg: {Color} \nAntal hjul: {NumberOfWheels}\n";
        }
    }
    #region
    //public class Vehicle
    // {

    //     public int NumberOfWheels { get; private set; }
    //     public string RegistrationNumber { get; private set; }
    //     public string? Color { get; private set; }




    #endregion

}

