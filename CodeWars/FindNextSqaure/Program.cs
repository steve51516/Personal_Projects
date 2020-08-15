using System;

namespace FindSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            // Numbers to test:
            // [TestCase(155, ExpectedResult=-1)]
            // [TestCase(121, ExpectedResult=144)]
            // [TestCase(625, ExpectedResult=676)]
            // [TestCase(319225, ExpectedResult=320356)]
            // [TestCase(15241383936, ExpectedResult=15241630849)]

            long num = Kata.FindNextSquare(625);
            System.Console.WriteLine(num);
        }
    }
    public class Kata
    {
        public static long FindNextSquare(long num)
        {
            double test = Math.Sqrt(num);
            if (test % 1 != 0)
                return -1;
            long nextN = (long)Math.Floor(Math.Sqrt(num)) + 1;
            return (long)Math.Pow(nextN, 2);
        }
    }
}
