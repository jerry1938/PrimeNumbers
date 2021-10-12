using System;
using System.Collections.Generic;

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
                if (IsPrime(number)) Console.WriteLine("True");
                else Console.WriteLine("False");
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
    }
}