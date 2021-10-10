using System;
using PrimeFactorsLib;

namespace AppPrimeFactors
{
    class Program
    {
        // Create a function to call PrimeFactors
        static void RunPrimeFactors(int number)
        {
            Console.Write($"Prime factors of {number} are: ");
            var prime = new PrimeFactors();
            prime.GetPrimeFactors(number);

            for (int i = 0; i < prime.listLength; i++)
            {
                if (i == 0) 
                {
                    Console.Write($"{prime.primeFactorsList[i]} ");
                }
                else
                {
                    Console.Write($"x {prime.primeFactorsList[i]} ");
                }
                
            }
        }
        
        static void Main(string[] args)
        {
            Console.Write("Enter a number to find its prime factors: ");
            int number = int.Parse(Console.ReadLine());

            RunPrimeFactors(number);
        }
    }
}
