
/*
 The code creates an integer array and reverses it by swapping elements on opposite ends of the
 array using a for loop and a temporary variable. The reversed array is then printed to console
 using `string.Join()`. This is an efficient way to reverse an array in C#.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveDaysTrainings
{
    internal class ReverseArray
    {
        
    public void reverse_array() {
           
            Console.WriteLine("\nReverse Array");

            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            int n = arr.Length;

            for (int i = 0; i < n / 2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[n - i - 1];
                arr[n - i - 1] = temp;
            }
            Console.WriteLine(string.Join(",", arr));


            Console.WriteLine("--------------------------------");
        }
    }
    
}
