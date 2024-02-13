/*
 The Maximum Subarray Algorithm is a divide-and-conquer algorithm used in computer science to
 find the contiguous subarray with the largest sum within a given one-dimensional array of numbers

 applied to a variety of problems in computer science and mathematics, such as financial data analysis,
 image processing, and machine learning. It can also be used when working with large data sets and databases
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FiveDaysTrainings
{
    internal class MaxSubArray
    {
    public void max_sub_array()
    {
            Console.WriteLine("\nMAX SUB ARRAY");

            int[] arr = {1,2,3,4,5,6,7,8,-99};

            int max = int.MinValue;
            int max_ending = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                max_ending += arr[i];

                if(max < max_ending)
                {
                    max = max_ending;
                }
                if(max_ending < 0)
                {
                    max_ending = 0;
                }
            }

            Console.WriteLine("Maximun sub-array sum:  " + max);

            Console.WriteLine("--------------------------------");
        }
    }
}
