namespace Garage
{

    //All text
    public static class Menus
    {

        

        public static void PrintMainManu()
        {

            Console.WriteLine(" Skriv in en siffra för att välja en åtgärd:    ");
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            Console.WriteLine("*   0. Avsluta                                  *");
            Console.WriteLine("*   1. Skapa ett garage                         *");
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");



        }

        internal static void PrintOpeningGarageMenu(int capacity)
        {
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            Console.WriteLine("*         *         *         *         *         *         *           *");
            Console.WriteLine("*         *         *         *         *         *         *           *");
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            Console.WriteLine("*                                                                       *");
            Console.WriteLine($"*     VÄLKOMMEN TILL GARAGET                                           *");
            Console.WriteLine($"*     Du har nu skapat ett garage med {capacity} platser                        *");
            Console.WriteLine("*        Här kan du göra följande val :                                 *");
            Console.WriteLine("*        2. Populerar garaget                                           *");
            Console.WriteLine("*        3. Lista samtliga fordon                                       *");
            Console.WriteLine("*        4. Parkera ett nytt fordon                                     *");
            Console.WriteLine("*        5. Hämta ut fordon                                             *");
            Console.WriteLine("*        6. Lista hur många av olika sorters fordon som finns i garaget *");
            Console.WriteLine("*        7. Hitta ett specifikt fordon i garaget                        *");
            Console.WriteLine("*        8. Sök fordon efter olika egenskaper                           *");
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            Console.WriteLine(" ");

        }

        internal static void wrongSearch()
        {
            throw new NotImplementedException();
        }

        internal static void PrintWhichVehicle()
        {
            throw new NotImplementedException();
        }

        internal static void PrintGarageMenu()
        {
          //  Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
              Console.WriteLine("Vad vill du göra nu?                                           ");

           // Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            Console.WriteLine(" ");
        }
        internal static void PrintParkingTypeMenu()
        {
            //  Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            Console.WriteLine("Vilken typ av fordon vill du parkera?  ");
            Console.WriteLine("A. Bil\nB. Buss\nC. Flyg\nD: Motorcyckel\nE: Båt");
            // Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            Console.WriteLine(" ");
        }

        internal static void PrintCheckOutOkay(string? checkOutRegNr)
        {
            Console.WriteLine($"Fordnet med registreringsnummer {checkOutRegNr} finns inte längre i garaget");
            PrintGarageMenu();
        }

        internal static void PrintCheckoutMenuNotOkay(string? checkOutRegNr)
        {
            Console.WriteLine("Graget lyckades inte hitta ditt fordon.");

            PrintGarageMenu();
        }

        internal static void PrintQWheels()
        {
            Console.WriteLine("\nHur många hjul har fordonet?  ");
        }
        internal static void PrintQRegistrationNr()
        { 
            Console.WriteLine("\nVilket registreringnummer har fordonet?");       
        }
        internal static void PrintQColor()
        {
            Console.WriteLine("\nVilket färg har fordonet?");
        }
        internal static void PrintParkingCarFuel()
        {
            Console.WriteLine("Vilket drivmedel har fordonet?");
            Console.WriteLine("A: Disel\nB: Bensin\nC: Annat");
        }
        internal static void PrintParkingBusMenu1()
        {
            Console.WriteLine("Hur många sittplatser har fordonet?");
        }
        internal static void PrintParkingMotorcycle()
        {
            Console.WriteLine("Hur många cylindrar har den?");
        }
        internal static void PrintParkingBoat()
        {
            Console.WriteLine("Hur lång är den?");
        }

    

        internal static void PrintParkingAirplane()
        {
            Console.WriteLine("Hur många motorer har den?");
        }
        internal static void InvalidMessage()
        {
            Console.WriteLine("Fel input. Följ instruktionen, tack");
        }

        internal static void SearchMenu()
        {
            Console.WriteLine("Vill du solla på typ");
            Console.WriteLine("A. Bil\nB. Buss\nC. Flyg\nD: Motorcyckel\nE: Båt");

        }

        internal static void SearchMenuColor()
        {

            Console.WriteLine("Skriv in en färg om du vill solla på den, alternativt tryck enter");
        }

        internal static void PrintCheckoutMenu()
        {
            Console.WriteLine("Välkommen till Checkout!\nSkriv in registreringsnumret på fordonet som ska checkas ut: ");
        }

        internal static void SearchMenuWheels()
        {
            Console.WriteLine("Skriv in antal hjul om du vill solla på den, alternativt tryck enter");
        }
    }
}
