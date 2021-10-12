using System;

namespace PrimeNumbers
{
    public static class MenuHandler
    {
        /// <summary>
        /// Prints a menu with 4 choices.
        /// It runs until the user enters a number between 1-4.
        /// </summary>
        /// <returns>The choice.</returns>
        public static int Menu(){
            bool isNumeric;
            int choice;

            do
            {
                Console.Clear();
                Console.WriteLine("1. Enter a number.\n"+
                    "2. Add next prime number.\n"+
                    "3. Print data structure.\n"+
                    "4. Exit.");
                Console.Write("> ");

                isNumeric = int.TryParse(Console.ReadLine(), out choice);
                if(!isNumeric || choice < 1 || choice > 4) Error();
            } while (!isNumeric || choice < 1 || choice > 4);

            return choice;
        }

        /// <summary>
        /// Prints an error message.
        /// </summary>
        private static void Error(){
            Console.WriteLine("Please enter a valid number.");
            Console.ReadKey();
        }
    }
}