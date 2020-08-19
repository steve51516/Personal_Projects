using System;

namespace findTheDivisors
{
    class Program
    {
        static void Main(string[] args)
        {

            var vs = Kata.Divisors(24);
            if (vs != null)
            {
                foreach (var num in vs)
                {
                    Console.WriteLine(num);
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

            int j = 0;
            int k = 2;
            for (int i = 0; i < (n / 2); i++)
            {
                if (n % k == 0)
                    j++;
                k++;
            }
            int[] vs = new int[j];
            j = 0;
            k = 2;
            for (int i = 0; i <= (n / 2); i++)
            {
                if (n % k == 0)
                {
                    vs[j] = (n / k);
                    j++;
                }
                k++;
            }
            Array.Sort(vs);
            if (j == 0)
                return null;
            else
                return vs;
        }
        public static bool IsPrime(int n)
        {
            if (n <= 1)
                return false;
            if (n == 2)
                return true;
            if (n % 2 == 0)
                return false;
            if (Math.Sqrt(n) == 5)
                return false;

            int boundary = (int)Math.Floor(Math.Sqrt(n));

            for (int i = 3; i < boundary; i += 2)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
    }
}
