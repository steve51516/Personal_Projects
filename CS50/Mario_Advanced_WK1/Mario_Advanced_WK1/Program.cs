using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mario_Advanced_WK1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count;
            do // Test users number and loop until it's between 1 and 8
            {
                Console.WriteLine("Enter a number between 1 and 8: ");
                count = int.Parse(Console.ReadLine());
            } while (count < 0 || count > 8);

            Mario mario = new Mario();
            mario.Build(count);
        }
    }
    class Mario
    {

        public void Build(int height)
        {
            int x = height;
            while (height > 0)
            {
                int length = height - 1;
                int len2 = 0;
                int width = height - 1;
                int wid2 = height - 1;
                while (length > 0)
                {
                    Console.Write(" ");
                    length--;
                }
                do
                {
                    width++;
                    Console.Write("#");
                } while (width < x);
                while (len2 < 1)
                {
                    Console.Write("  ");
                    len2++;
                }
                do
                {
                    wid2++;
                    Console.Write("#");
                } while (wid2 < x);
                height--;
                Console.Write("\n");
            }
        }

    }
}
