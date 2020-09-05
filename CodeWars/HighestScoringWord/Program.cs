using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighestScoringWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string winner = Kata.High("man i need a taxi up to ubud");
            Console.WriteLine(winner);
        }
    }
    public class Kata
    {
        public static string High(string s)
        {
            char[] charArr = s.ToCharArray();
            int[] intValues = new int[s.Split(' ').Length];
            for (int i = 0, j = 0; i <= intValues.Length - 1; i++)
            {
                while (charArr[j] != ' ')
                {
                    intValues[i] += charArr[j];
                    if (j >= 27)
                        break;
                    else
                        j++;
                }
                if (charArr[j] == ' ' && j < 27)
                    j++;
            }
            string[] strArr = s.Split(' ');
            int maxValue = intValues.Max();
            int maxIndex = intValues.ToList().IndexOf(maxValue);
            return strArr[maxIndex];
        }
    }
}
