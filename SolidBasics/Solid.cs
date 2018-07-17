using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidBasics
{
    class Solid
    {
        static void Main(string[] args)
        {
            bool continueExecution = true;
            do
            {
                Console.Write("Enter First Name: ");
                var firstName = Console.ReadLine();
                Console.Write("Enter Last Name: ");
                var lastNAme = Console.ReadLine();

                Console.Write("Do you want to save? Y/N: ");
                var wantToSave = Console.ReadLine();

                if (wantToSave.ToUpper() == "Y")
                {
                    SaveToDB(firstName, lastNAme);
                }

                Console.Write("Do you want to exit? Y/N: ");
                var wantToExit = Console.ReadLine();

                if (wantToExit.ToUpper() == "Y")
                {
                    continueExecution = false;
                }
            } while (continueExecution);
        }

        private static void SaveToDB(string firstName, string lastName)
        {
            //save firstName and lastName to the database here..
        }
    }
}
