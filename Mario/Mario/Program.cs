using System;

namespace Mario
{
    class Program
    {
        static void Main(string[] args)
        {
            int count;
            do
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
                int width = height - 1;
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
                height--;
                Console.Write("\n");
            }
        }

    }
}
