using System;

namespace SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sortMe = { 1, 2, 3, 10, 5 }; //new int[] { 1, 2, 3, 5, 10 }
            int[] arrSorted = Kata.SortNumbers(sortMe);

            foreach (var num in arrSorted)
            {
                Console.Write(num + " ");
            }
        }
    }
    public class Kata
    {
        public static int[] SortNumbers(int[] nums)
        {
            if (nums == null)
            {
                int[] vs = new int[0];
                return vs;
            }
            int temp = 0;
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                for (int x = 0; x < nums.Length - 1; x++)
                {
                    if (nums[x] > nums[x + 1])
                    {
                        temp = nums[x + 1];
                        nums[x + 1] = nums[x];
                        nums[x] = temp;
                    }
                }

            }
            
            return nums;
        }
    }
}
