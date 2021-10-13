using System;
using System.Collections.Generic;

namespace PrimeNumbers
{
    public class PrimeNumber
    {
        public static List<int> primeNumbers = new();

        /// <summary>
        /// The user can enter a number and if the number is a prime number then
        /// it will be stored in a data structure and print that the number is a
        /// prime number to the screen. If the number is not a prime number the
        /// method will print that it is not a prime number.
        /// </summary>
        public static void AddPrime(){
            Console.Clear();
            Console.Write("Enter a number: ");

            bool isNumeric = int.TryParse(Console.ReadLine(), out int number);
            if (isNumeric){
                if (IsPrime(number)) {
                    Console.Clear();
                    Console.WriteLine(
                        "The number you entered is a prime number.");
                    primeNumbers.Add(number);
                    Console.ReadKey();
                    // Sorts the numbers after they have been added.
                    SortPrimeNumbers();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(
                        "The number you entered is not a prime number.");
                    Console.ReadKey();
                }
            }
            else{
                // Error
            }
        }

        /// <summary>
        /// Checks if the number is a prime number or not.
        /// </summary>
        /// <param name="number">The number to check.</param>
        /// <returns>True if the number is a prime number, false if not.
        /// </returns>
        public static bool IsPrime(int number){
            // A prime number must be bigger than 1.
            if (number <= 1) return false;
            for (int i = 2; i < number; i++)
            {
                // A prime number cannot be evenly divisible by anoything other
                // than itself and 1.
                if (number % i == 0) return false;
            }
            return true;
        }

        /// <summary>
        /// Calculates what the next prime number is based on the highest number
        /// in the data structure.
        /// </summary>
        public static void GetNextPrime(){
            Console.Clear();
            int lastNum;
            int nextNum = 2; // First and default prime number.

            if (primeNumbers.Count < 1) lastNum = 0;
            else lastNum = primeNumbers[^1];
            // Because the lastNum is a prime number we need to start by 
            // lastNum+1.
            // There is always a prime number between lastNum+1 and lastNum * 2.
            for (int i = lastNum + 1; i < lastNum * 2; i++)
            {
                if (IsPrime(i)){
                    nextNum = i;
                    break;
                }
            }
            Console.WriteLine($"The next prime number is {nextNum}");
            // Adds the prime number to the data structure.
            primeNumbers.Add(nextNum);
            Console.ReadKey();
        }

        /// <summary>
        /// Prints the data structure to the screen.
        /// </summary>
        public static void PrintDataStructure(){
            foreach (var item in primeNumbers)
            {
                Console.Write($"{item}  ");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Sorts the data structure from the smallest prime number to the
        /// largest prime number.
        /// </summary>
        private static void SortPrimeNumbers(){
            for (int i = 0; i < primeNumbers.Count; i++)
            {
                int lowestNum = i; // stores the position of the lowest number.
                // int numI = primeNumbers[i];
                for (int j = i + 1; j < primeNumbers.Count; j++)
                {
                    // int numJ = primeNumbers[j];
                    if (primeNumbers[j] < primeNumbers[lowestNum]){
                        lowestNum = j; // Updates the current lowest num.
                    }
                }
                // Saves the larger number in a temp variable.
                int temp = primeNumbers[i];
                // Updates the number on position "i" with the lowest number.
                primeNumbers[i] = primeNumbers[lowestNum];
                // Updates the value of the lowest numbers old position in the
                // data structure with the temp value.
                primeNumbers[lowestNum] = temp;
            }
        }
    }
}