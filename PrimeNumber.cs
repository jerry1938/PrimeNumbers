using System;
using System.Collections.Generic;
using System.Linq;

namespace PrimeNumbers
{
    public class PrimeNumber
    {
        public static List<int> primeNumbers = new();
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
        public static bool IsPrime(int number){
            if (number <= 1) return false;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        public static void GetNextPrime(){
            Console.Clear();
            int lastNum;
            int nextNum = 2; // First and default prime number.

            if (primeNumbers.Count < 1) lastNum = 0;
            else lastNum = primeNumbers.Max();
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
            primeNumbers.Add(nextNum);
            Console.ReadKey();
        }

        public static void PrintDataStructure(){
            foreach (var item in primeNumbers)
            {
                Console.Write($"{item}  ");
            }
            Console.ReadKey();
        }

        private static void SortPrimeNumbers(){
            for (int i = 0; i < primeNumbers.Count; i++)
            {
                int lowestNum = i; // stores the position of the lowest number.
                // int numI = primeNumbers[i];
                for (int j = i + 1; j < primeNumbers.Count; j++)
                {
                    // int numJ = primeNumbers[j];
                    if (primeNumbers[j] < primeNumbers[lowestNum]){
                        lowestNum = j;
                    }
                }
                int temp = primeNumbers[i];
                primeNumbers[i] = primeNumbers[lowestNum];
                primeNumbers[lowestNum] = temp;
            }
        }
    }
}