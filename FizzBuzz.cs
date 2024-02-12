/*
 In the above code, we use a for loop to iterate from 1 to 100. We then check if 
 each number in the loop is divisible by 3 and/or 5, and print "Fizz" for numbers 
 divisible by 3, "Buzz" for numbers divisible by 5, "FizzBuzz" for numbers divisible
 by both 3 and 5, and the number itself for all other cases.
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveDaysTrainings
{
    internal class FizzBuzz
    {
    public void fizz_buzz()
    {
            int item = 89;
            
            for(int a = item; a <= 100; a++)
            {
                if(a % 3 == 0 && a % 5 == 0)
                {
                    Console.WriteLine("FIZZBUZZ");
                }
                else if (a % 5 == 0)
                {
                    Console.WriteLine("FIZZ");
                }
                else if (a % 3 == 0)
                {
                    Console.WriteLine("BUZZ");
                }
                else
                {
                    Console.WriteLine(item);
                }
            }
    }
    }
}
