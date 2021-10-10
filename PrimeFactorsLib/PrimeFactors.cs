using System;
using System.Text;
using System.Collections.Generic;
using static System.Console;

namespace PrimeFactorsLib
{
    public class PrimeFactors
    {
        public List<int> primeFactorsList = new List<int>();
        public int listLength = 0;
        
        // Check if number is prime
        /// <summary>
        /// Determine if a number is prime
        /// </summary>
        /// <param name="number">Input number to be checked</param>
        /// <returns>bool value of True or False</returns>
        public bool IsPrimeNumber(int number)
        {
            bool prime = true;
            int factor = number / 2;

            for (int i = 2; i <= factor; i++)
            {
                if ((number % i) == 0)
                {
                    prime = false;
                }
            }
            return prime;
        }
        
        /// <summary>
        /// Get prime factors of input number
        /// </summary>
        /// <param name="number">Input number</param>
        /// <returns>Prime factors of input number</returns>
        public List<int> GetPrimeFactors(int number)
        {
            // Take out all the 2s,
            // which is is the smallest prime factor
            while (number % 2 == 0)
            {
                primeFactorsList.Add(2);
                number /= 2;
            }

            // Take out other primes
            // 3 is the next prime factor after 2,
            // and after that they are the increments of 2
            int factor = 3;
            while (factor * factor <= number)
            {
                if (number % factor == 0)
                {
                    // This is a prime factor
                    primeFactorsList.Add(factor);
                    number /= factor;
                }
                else
                {
                    // Go to the next odd number
                    factor += 2;
                }
            }

            // If number is not 1,
            // then whatever left is a prime too
            if (number > 1)
            {
                primeFactorsList.Add(number);
            }

            listLength = primeFactorsList.Count;
            return primeFactorsList;
        }

        
    }
}
