using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveDaysTrainings
{
    internal class CalculateFactorial
    {
        public void prime_factorial()
        {
            Console.WriteLine("\nPRIME FACTORIAL ");
            int input = 12;
            int result =1;

            for(int i = 1; i <= input; i++)
            {
                result *= i;
            }

            Console.WriteLine("Input number:"+input+": factorial is: "+ result );

            Console.WriteLine("--------------------------------");

        }
    }
}
