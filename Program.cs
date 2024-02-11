using System.Security.Cryptography;
// 02-12-2024

/*
 1.REVERSE STRING
 2.REVERSE ARRAY
 3. FIZZ BUZZ 
 */


Console.WriteLine("Reverse String");

string str = "Domain";
string rev = string.Empty;

/* loop , will get the length of str , had -1 because array start with 0 , and i > 0 
greater than 0 means true and decrement , get the last value of string and print - 
 */
for(int i = str.Length-1; i >=0; i--)
{
    rev += str[i];
}

Console.WriteLine(rev); // output 


// REVERSE ARRAY

Console.WriteLine("Reverse Array");

int[] arr = { 1,2,3,4,5,6,7};
int n = arr.Length;

for (int i = 0; i < n / 2; i++ )
{
    int temp = arr[i];
    arr[i] = arr[n-i-1];
    arr[n - i - 1] = temp;
}
Console.WriteLine(string.Join(",",arr));


// FIZZ BUZZ 

Console.WriteLine("FIZZ BUZZ QUEST");

int item =78;

for(int i = item; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(i);
    }

}