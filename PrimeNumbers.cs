/*
 *In this code, the  function takes an integer as input and returns a boolean value 
 *indicating whether the input number is prime or composite. We start by testing if 
 *the input number is less than 2 (in which case it is neither prime nor composite).
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveDaysTrainings
{
    internal class PrimeNumbers
    {

        public void prime_numbers()
        {
            Console.Write("Prime Numbers");

            Console.Write("\nEnter a number: ");
            int n = int.Parse(Console.ReadLine());

            if (IsPrime(n))
            {
                Console.WriteLine(n + " is a prime number.");
            }
            else
            {
                Console.WriteLine(n + " is a composite number.");
            }


            Console.WriteLine("--------------------------------");
        }



        private static bool IsPrime(int n)
        {
            if (n < 2) return false;
            if (n == 2 || n == 3) return true;
            if (n % 2 == 0 || n % 3 == 0) return false;

            for (int i = 5; i <= Math.Sqrt(n); i += 6)
            {
                if (n % i == 0 || n % (i + 2) == 0)
                {
                    return false;
                }
            }

            return true;
        }

    }
}
