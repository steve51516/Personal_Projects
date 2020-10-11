using System;

namespace MultiplesOf3Or5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.Solution(10));
            Console.WriteLine(Kata.Solution(20));
            Console.WriteLine(Kata.Solution(200)); // Correct result is 9168
        }
    }
    class Kata
    {
        public static int Solution(int value)
        {
            int sum = 0;
            for (int i = 3; i < value; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;
            }
            return sum;
        }
    }
}
