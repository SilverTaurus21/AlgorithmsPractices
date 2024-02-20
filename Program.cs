/*
 Practice Code by SilverTaurus 2024
 */
using FiveDaysTrainings;
  class Program
    {
        public static void Main(string[] args)
        {
            ReverseArray rva = new ReverseArray();
            ReverseString rvs = new ReverseString();
            FizzBuzz fizzBuzz = new FizzBuzz();
            MaxSubArray msa = new MaxSubArray();
            CalculateFactorial cf = new CalculateFactorial();
            PrimeNumbers pf = new PrimeNumbers();

        rva.reverse_array();
        rvs.reverse_string();
        fizzBuzz.fizz_buzz();
        msa.max_sub_array();
        cf.prime_factorial();
        pf.prime_numbers();

    }

}
