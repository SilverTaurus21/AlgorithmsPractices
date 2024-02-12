/*
 The given code uses a for loop to iterate through the characters of a string in reverse order,
 and appends each character to a new string in reverse order to create a reversed string. 
 The reversed string is then printed to the console. This is not the most efficient method
 to reverse a string, and there are better ways such as using the  method or  class 

 but this code might show how loops are used into for further undertanding 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveDaysTrainings
{
    internal class ReverseString
    {
    public void reverse_string()
    {
            Console.WriteLine("\nReverse String");

            string str = "HELLOE WORLD";
            string rev = string.Empty;

            for(int a = str.Length-1; a >=0; a--)
            {
                rev += str[a];
            }
            Console.WriteLine(rev);


            Console.WriteLine("--------------------------------");
        }
    }
}
