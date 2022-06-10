using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Kontrollklass

namespace Garage
{

    public static class Utility
    {


        public static bool IsNumeric(string userInput)
        {
            {
                int intInput;
                return int.TryParse(userInput, out intInput);
            }
           
        }

        internal static bool InputControl1(string? input)
        {
            var Validinput = "01";
            if (string.IsNullOrEmpty(input) )
                Menus.InvalidMessage();
                return false;

        }



        //public static bool IsRegistrationNumber(string regNumber)
        //{
        //    string MyReg = regNumber.Trim();

        //    if (MyReg.Length != 6) return false;
        //    else return true;

        //    string partOne = MyReg.Substring(0, 2); // 3 x bokstäver
        //   // string partTwo = MyReg.Substring(3, 5); //3 x siffror

        //    foreach (char c in partOne)
        //    {
        //        if (!char.IsLetter(c))
        //            return false;
        //        else return true;
        //    }
        //if (!IsNumeric(partTwo)) return false;
        //else return true ;

        //var test = "7";
        //var 



        //var alphanumeric = "ABC..xyz1234567890";

        //var bool1 = alphanumeric.Contains(test);



        // }   
    }

}









