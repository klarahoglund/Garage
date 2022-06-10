using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    //Här ligger logiken som används i Manager och kommunikation med U
    static class UserInput

    {

       
        public static string ParkingType(string tempType)
        {


            //string info = key.KeyChar.ToString().ToUpper();
            //if (string.IsNullOrEmpty(info)) Menus.InvalidMessage();

            switch (tempType.ToUpper())
            {
                case "A":
                     return "Car";
                case "B":
                    return "Bus";
                case "C":
                    return "Airplane";
                case "D":
                    return "Motorcycle";

                case "E":
                    return "Boat";
                default:
                    return "Du måste göra ett korrekt val. A, B, C, D eller E";
            }
        }

        public static string SpecificValues(string inputParkingType)
        {
            switch(inputParkingType)
            {
                case "Car":
                    Menus.PrintParkingCarFuel();
                    string? tempFuel = Console.ReadLine().ToUpper();
                    if (!string.IsNullOrEmpty(tempFuel))
                    {
                        if (tempFuel == "A")
                            return "Disel";
                        if (tempFuel == "B")
                            return "Bensin";
                        if (tempFuel == "C")
                            return "Annat";
                    }
                    else return "Annat";
                    break;
                case "Bus":
                    Menus.PrintParkingBusMenu1();
                    string? tempBus = Console.ReadLine();
                    if (!string.IsNullOrEmpty(tempBus) )
                    {
                        return tempBus;
                    }
                    else return "-1";
                case "Airplane":
                    Menus.PrintParkingAirplane();
                    string ? tempAirplane = Console.ReadLine();
                    if (!string.IsNullOrEmpty(tempAirplane))
                    {
                        return tempAirplane;
                    }
                    else return "-1";
                case "Motorcycle":
                    Menus.PrintParkingMotorcycle();
                    string? tempMotorcycle = Console.ReadLine();
                    if (!string.IsNullOrEmpty(tempMotorcycle) )
                    {
                        return tempMotorcycle;
                    }
                    else return "-1";
                   
                case "Boat":
                Menus.PrintParkingBoat();
                    string? tempBoat = Console.ReadLine();
                    if (!string.IsNullOrEmpty(tempBoat))
                    {
                        return tempBoat;
                    }
                    
                        else return "-1";

                default:
                    return "Du måste göra ett korrekt val. ";

            }
            return "-1";


           
        }
       
        
    }
}





        //internal static void MenuPaths(string inputParkingType)
        //{
        //    switch(inputParkingType)
        //    {
        //        case "Car":
        //            Menus.PrintParkingCarFuel();
        //            string ? tempFuel = Console.ReadLine();


        //    Console.WriteLine("it is a car");
        //}
        //string ? tempFuel = Console.ReadLine();
        //    inputParkingType.ToUpper();
        // return inputParkingType;

    
