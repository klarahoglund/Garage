using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//CONCRETE PRODUCT
namespace Garage
{
    internal class Car : Vehicle
    {
        //private int numberOfWheels;
        //private string ? registrationNumber;
        //private string? color;
        public string FuelType;
        public Car(int numberOfWheels, string registrationNumber, string color, string fuelType) 
            : base(numberOfWheels, registrationNumber, color)
        {
            NumberOfWheels = numberOfWheels;
            RegistrationNumber = registrationNumber;
            Color = color;
            FuelType = fuelType;
        }

        //public int NumberOfWheels 
        //{ 
        //    get { return numberOfWheels; }
        //    set { numberOfWheels = value; }
        //}
        //public string RegistrationNumber 
        //{
        //    get { return registrationNumber; }
        //    set { registrationNumber = value; }
        //}
        //public string? Color 
        //{
        //    get { return Color; }
        //    set { Color = value; }
        //}

        #region
        //public Car(int numberOfWheels, string registrationNumber, string color, string fuelType) 
        //        : base(numberOfWheels, registrationNumber, color)
        //{
        //    this.FuelType = fuelType;
        //}
#endregion
        public override string ToString()
        {
            return base.ToString() + $"Bränsle: {FuelType}";
        }
    }
}
