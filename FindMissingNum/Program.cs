using System;

namespace TestCodeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random random = new Random();
            int[] vs = new int[100];
            for (int i = 0; i < 100; i++)
            {
                vs[i] = i;
            }
            vs[50] = 0;

            Find find = new Find();

            int missingInt = find.FindMissing(vs);
            System.Console.WriteLine(missingInt);
        }

    }
    public class Find
    {
        public int FindMissing(int[] vs)
        {
            for (int i = 0; i < vs.Length - 1; i++)
            {
                 if (vs[i] != i)
                 {
                    System.Console.WriteLine($"{i} is the missing number");
                    return i;
                 }
            }
            System.Console.WriteLine("No missing number found.");
            return 0;

        }
    }
}
