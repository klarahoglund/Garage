using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    //Flödet av programmet
    internal class Manager
    {
        public GarageHandler handler;

     
        private int tempnrOfWheels;
        private string tempReg;
        private string tempColor;
        private string? inputParkingType;

        private string menuChoice = "1";
        private bool parkingInProgress;

        internal void Run()
        {
            parkingInProgress = true;
            do
            {
                if(menuChoice == "1")
                Menus.PrintMainManu();
                if (menuChoice == "2")
                 Menus.PrintOpeningGarageMenu(handler.GetGarageSize());
                if (menuChoice == "3")
                    Menus.PrintGarageMenu();
                //if (menuChoice == "4")
                //    Menus.InvalidMessage();
                //    Menus.SearchMenu();

                    string ? input = Console.ReadLine();
                   // if(Utility.InputControl1(input))

                    
                switch(input)

                {
                    #region
                    case "0": //lämnar programmet
                        Console.WriteLine("Tack och adjö");
                        parkingInProgress = false;
                        Environment.Exit(0);
                        break;
                    case "1": //
                        Console.WriteLine("Hur många parkeringsplatser ska garaget ha?");
                        string ? inputToo = Console.ReadLine();
                        if (Utility.IsNumeric(inputToo) && !string.IsNullOrEmpty(inputToo))
                        {
                            var nrOfParkingspaces = int.Parse(inputToo);
                            handler = new GarageHandler(nrOfParkingspaces);
                            menuChoice = "2";
                        }
                        break;
                    case"2":
                        handler.PopulateGarage();
                        menuChoice = "3";
                        break;
                    case"3":
                        handler.PrintGarage();
                       
                        break;
                    #endregion
                    case "4":
                        Menus.PrintParkingTypeMenu();
                        //ConsoleKeyInfo key = Console.ReadKey();
                        string ? tempType = Console.ReadLine();
                        if (!string.IsNullOrEmpty(tempType))
                            inputParkingType = UserInput.ParkingType(tempType);
                        else Menus.InvalidMessage();

                        Menus.PrintQWheels();
                        string ? tempWheels = Console.ReadLine();
                        if(!string.IsNullOrEmpty(tempWheels) && Utility.IsNumeric(tempWheels))  tempnrOfWheels = int.Parse(tempWheels);                   

                        Menus.PrintQRegistrationNr();
                        string ? temp = Console.ReadLine();
                        if (handler.IsUnique(temp)) tempReg = temp.ToUpper();

                        Menus.PrintQColor();
                        string ? temp2 = Console.ReadLine();
                       if(!string.IsNullOrEmpty(temp2)) tempColor = temp2;

                        string myProperty = UserInput.SpecificValues(inputParkingType);
                        

                        if (inputParkingType == "Car")
                            handler.ParkVehicle(new Car(tempnrOfWheels, tempReg, tempColor, myProperty));
                        else if (inputParkingType == "Bus")
                            handler.ParkVehicle(new Bus(tempnrOfWheels, tempReg, tempColor, myProperty));
                        else if (inputParkingType == "Airplane")
                            handler.ParkVehicle(new Airplane(tempnrOfWheels, tempReg, tempColor, myProperty));
                        else if (inputParkingType == "Motorcycle")
                            handler.ParkVehicle(new Motorcycle(tempnrOfWheels, tempReg, tempColor, myProperty));
                        else if (inputParkingType == "Boat")
                            handler.ParkVehicle(new Boat(tempnrOfWheels, tempReg, tempColor, myProperty));
                        else
                            Menus.InvalidMessage();
                        break;
                    case "5":
                        Menus.PrintCheckoutMenu();
                        string? checkOutRegNr = Console.ReadLine();
                        handler.CheckOutVehicle(checkOutRegNr);
                        break;
                    case "6":
                        handler.ListTypes();
                        break;
                    case "7":
                        Menus.PrintQRegistrationNr();
                        string? findReg = Console.ReadLine();
                        handler.FindVehicle(findReg);
                        break;
                    case "8":
                            string type = "";
                            string? color = "";
                            int wheels = -1;

                            Menus.SearchMenu();
                            string? searchtype = Console.ReadLine();
                            if (!string.IsNullOrEmpty(searchtype))
                                type = UserInput.ParkingType(searchtype);

                            Menus.SearchMenuColor();
                            string? searchcolor = Console.ReadLine();
                            if (!string.IsNullOrEmpty(searchcolor))
                                color = searchcolor;

                            Menus.SearchMenuWheels();
                            string ? searchwheels = Console.ReadLine();
                            if (!string.IsNullOrEmpty(searchwheels) && Utility.IsNumeric(searchwheels))
                                wheels = int.Parse(searchwheels);

                            handler.Search(type, color, wheels);
                         
                        break;
                    default:
                        break;

                }
               

            } while(parkingInProgress);
        }

        //public void DoSearch()
        //{
        //    Console.WriteLine("What color?");
        //    var color = Console.ReadLine();
        //    //...
        //    //...
        //    Console.WriteLine("Number of wheels?");
        //    var nrOfWheels = int.Parse(Console.ReadLine());
        //    handler.Search(color);
        //}
    }
}


//UserInput.MenuPaths(inputParkingType);


// Menus.PrintQRegistrationNr();

//string ? tempReg = Console.ReadLine();


//if (!string.IsNullOrEmpty(tempReg) && Utility.IsRegistrationNumber(tempReg))
//{
//    string okayRegNumber = tempReg;
//}

//if (inputParkingType == "A") {
//    
//   
//    if (!string.IsNullOrEmpty(tempFuel))
//    {
//        tempFuel.ToUpper();
//        if (tempFuel == "A") tempFuel = "Disel";
//        if (tempFuel == "B") tempFuel = "Bensin";
//        if (tempFuel == "C") tempFuel = "El";
//        if (tempFuel == "D") tempFuel = "Annat";

//    }
//}
//else if (inputParkingType == "B")
//    Menus.PrintParkingBusMenu1();
//    string ? tempSeats = Console.ReadLine();
//    if (string.IsNullOrEmpty(tempSeats) && !Utility.IsNumeric(tempSeats))
//    {
//        Menus.InvalidMessage();

//    }
//else
//{
//    Menus.InvalidMessage(); 
//}

//Menus.PrintQWheels();
//string ? tempwheel = Console.ReadLine();
//if(string.IsNullOrEmpty(tempwheel) && !Utility.IsNumeric(tempwheel))
//{
//    Menus.InvalidMessage();
//    break;
//}





//Menus.PrintQColor();

