using System;
using System.Collections.Generic;

namespace findTheDivisors
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] Divisors = Kata.Divisors(16);
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

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    if (i != Math.Sqrt(n))
                        Divisors.Add(i);
                    Divisors.Add(n / i);
                }
            }
            Divisors.Sort();
            int[] vs = Divisors.ToArray();
            if (Divisors.Count == 0)
                return null;
            else
                return vs;
        }
    }
}
