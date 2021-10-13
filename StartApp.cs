using System;

namespace PrimeNumbers
{
    public static class StartApp
    {
        /// <summary>
        /// Keeps the program running until the user decides to exit. Runs the
        /// correct method depending on what the user wants to do in the
        /// program.
        /// </summary>
        public static void Start(){
            bool exitProgram = false;
            int choice;

            do
            {
                choice = MenuHandler.Menu();
                switch (choice)
                {
                    case 1:
                        PrimeNumber.AddPrime();
                        break;
                    case 2:
                        PrimeNumber.GetNextPrime();
                        break;
                    case 3:
                        PrimeNumber.PrintDataStructure();
                        break;
                    case 4:
                        exitProgram = true;
                        break;
                    default:
                        break;
                }
            } while (!exitProgram);
        }
    }
}