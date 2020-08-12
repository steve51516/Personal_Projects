using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();


            bool num = SquareOrNot(r.Next(1000));
            //bool num = SquareOrNot(625);

            Console.WriteLine($"\n{num}");


        }
        static public bool SquareOrNot(int x)
        {
            if (x < 0)
                return false;
            double y = Math.Sqrt(x);
            double num = x % y;
            Console.Write($"{x} % {y} remainder is {num}");

            if ((x % y) == 0)
                return true;
            else
                return false;
        }



    }
}
