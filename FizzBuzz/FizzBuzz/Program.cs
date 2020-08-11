using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                int fizzTrue = i % 3;
                if (fizzTrue == 0)
                    Console.WriteLine($"{i}: Fizz");
                int buzzTrue = i % 5;
                if (buzzTrue == 0)
                    Console.WriteLine($"{i}: Buzz");
            }
        }
    }
}
