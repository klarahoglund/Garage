using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public class MyGarage<T> : IEnumerable<T>  where T : Vehicle
    {
        private T[] vehicles { get; set; }
     
        
        public int NrOfParkingspaces { get; set; }
        
        public MyGarage(int nrOfParingspaces)
        {
             vehicles = new T[nrOfParingspaces];
            this.NrOfParkingspaces = nrOfParingspaces;
        }

        public void Park(T vehicle)
        {
            for(int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] == null)
                {
                    vehicles[i] = vehicle;
                   break;
                }  
            }
        }
        public bool CheckoutVehicle(T vehicle)
        {
            if (vehicle == null)
            {
                Menus.InvalidMessage();
            }

            for (int i = 0; i < vehicles.Length; i++)
            {
                if(vehicles[i] is not null && vehicles[i].RegistrationNumber == vehicle.RegistrationNumber)
                {
                    vehicles[i] = null;
                    return true;
                }
            }

            return false;
        }
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var vehicle in vehicles)
            {
                if(vehicle is not null)
                {
                    yield return vehicle;
                }
                //Är det ett fordon? Är det NUllcheck
                
            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
  
    }
        
    

    
}
