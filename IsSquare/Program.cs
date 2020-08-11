using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();


            //bool num = SquareOrNot(r.Next(1000));
            bool num = SquareOrNot(625);

            Console.WriteLine(num);


        }
        static public bool SquareOrNot(int x)
        {
            if (x < 0)
                return false;
            double y = Math.Sqrt(x);
            Console.Write($"{x} % {y}:" );
            double num = x % y;
            Console.WriteLine($"Remainder is {num}");

            if ((x % y) == 0)
                return true;
            else
                return false;
        }



    }
}
