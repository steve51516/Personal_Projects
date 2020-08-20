using System;
using System.Collections.Generic;

namespace findTheDivisors
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] Divisors = Kata.Divisors(24);
            if (Divisors != null)
            {
                foreach (var num in Divisors)
                {
                    Console.Write(num + " ");
                }
            }
            else
                Console.WriteLine("The supplied number is prime.");

        }
    }
    class Kata
    {
        public static int[] Divisors(int n)
        {
            if (n < 1)
                return null;

            List<int> Divisors = new List<int>();

            int j = 0;
            int k = 2;
            for (int i = 0; i <= (n / 2); i++)
            {
                if (n % k == 0)
                {
                    Divisors.Add(n / k);
                    j++;
                }
                k++;
            }
            Divisors.Sort();
            int[] vs = Divisors.ToArray();
            if (j == 0)
                return null;
            else
                return vs;
        }
    }
}
