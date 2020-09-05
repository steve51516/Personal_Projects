using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace HighestScoringWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string winner = Kata.High("man i need a taxi up to ubud");
            Console.WriteLine(winner);

            string winner2 = Kata.High("what time are we climbing up to the volcano");
            Console.WriteLine(winner2);

            string winner3 = Kata.High("take me to semynak");
            Console.WriteLine(winner3);

        }
    }
    public class Kata
    {
        public static string High(string s)
        {
            char[] charArr = s.ToCharArray();
            int[] intValues = new int[s.Split(' ').Length];
            //int[] alphabetValues = new int[26];
            //for (int i = 0, j = 1; i < alphabetValues.Length; i++, j++)
            //{
            //    alphabetValues[i] = j;
            //}
            List<char> alphabetChars = "aabcdefghijklmnopqrstuvwxyz".ToList<char>();
            for (int i = 0, j = 0; i <= intValues.Length - 1; i++)
            {
                while (charArr[j] != ' ')
                {
                    intValues[i] += alphabetChars.LastIndexOf(charArr[j]);
                    if (j >= charArr.Length - 1)
                        break;
                    else
                        j++;
                }
                if (charArr[j] == ' ' && j <= charArr.Length - 1)
                    j++;
            }
            string[] strArr = s.Split(' ');
            int maxValue = intValues.Max();
            int maxIndex = intValues.ToList().IndexOf(maxValue);
            return strArr[maxIndex];
        }
    }
}
