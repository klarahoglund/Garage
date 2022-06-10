using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Hanterar all funktionalitet för garaget
namespace Garage
{

    public class GarageHandler  
    {
        private MyGarage<Vehicle> garage;


       
        public GarageHandler(int capacity)
        {
            garage = new MyGarage<Vehicle>(capacity);
        }

        public  void PopulateGarage()
        {
            foreach(var vehicle in GetDummyVehicles())
            {
                garage.Park(vehicle);    
            }

        }
        public void ParkVehicle(Vehicle vehicle)
        {
            garage.Park(vehicle);
        }
        public void PrintGarage()
        {
           //var tempVehiclesArr = garage.GetVehicles();
           var tempVehiclesArr = garage.ToList(); // Vehcles
            Console.WriteLine("Dessa Fordon är parkerade just nu: ");

            foreach(var vehicle in tempVehiclesArr )
                Console.WriteLine(vehicle + "\n");
        }

        internal int GetGarageSize()
        {
           return garage.NrOfParkingspaces;   
           
        }

        public bool IsUnique(string regNr)
        {
            var tempVehiclesArr = garage.ToList();
            var temp = 
                from v in tempVehiclesArr
                where v !=null select v;
            bool isunique = true;

            foreach (var vehicle in temp)
            {
                if (regNr == vehicle.RegistrationNumber)
                {
                    isunique = false;
                    break;
                }

                else
                    isunique = true;

            }
            return isunique;
        }

        private List<Vehicle> GetDummyVehicles()
        {
            return new List<Vehicle>
            {
            new Car(4, "ABC123", "Red", "Diesel"),
            new Bus(8, "FED444", "Yellow", "40"),
            new Car(4, "DDD222", "White", "Diesel"),
            new Car(4, "CCC555", "Blue", "Diesel")
            };

        }
     

      internal void FindVehicle(string? findReg)
        {
            if (findReg != null)
            {
                string regUpper = findReg.ToUpper();
                var q = garage.First(v => v.RegistrationNumber == regUpper);
                Console.WriteLine(q.ToString());
            }
            else
                Menus.InvalidMessage();
        }

        internal void CheckOutVehicle(string? checkOutRegNr)
        {

            //if (checkedoutVehicles.Contains(checkOutRegNr))
            //    Menus.PrintCheckoutMenuNotOkay(checkOutRegNr);

            var q = garage.First(v => v.RegistrationNumber == checkOutRegNr);
               

            if(q == null)
            {
                Menus.PrintCheckoutMenuNotOkay(checkOutRegNr);
            }

            else if (garage.CheckoutVehicle(q))
            {
                Menus.PrintCheckOutOkay(checkOutRegNr);
                //checkedoutVehicles.Add(checkOutRegNr);
                
            }
            else Menus.PrintCheckoutMenuNotOkay(checkOutRegNr);
           
        }
        internal void ListTypes()
        {

            var groups = garage.GroupBy(v => v.GetType().Name);

            Console.WriteLine("Dessa fordonstyper och dessa antal står i garaget just nu:");

            foreach (var group in groups)
            {
                Console.WriteLine($"{group.Key} : {group.Count()}");

            }
            Console.WriteLine("\n");
        }

        public void Search(string type, string color = "", int nrOfWheels = -1)
        {
            var query = garage.Select(v => v);
            
            if (!string.IsNullOrEmpty(color))
            {
                query = query.Where(v => v.Color.ToLower()== color.ToLower());
            }

            if(nrOfWheels != -1)
            {
                query = query.Where(v => v.NumberOfWheels == nrOfWheels);
            }
            if(!string.IsNullOrEmpty(type))
            {
                query = query.Where(v => v.GetType().Name.ToLower()== type.ToLower());
            }     

            var result = query.ToList();
            Console.WriteLine("Din sollning gav följande: ");

            foreach (var vehicle in result)
            {
                Console.WriteLine(vehicle.ToString());
            }
        }

    
    }

}

