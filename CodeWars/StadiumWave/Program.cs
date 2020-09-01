using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StadiumWave
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> waveList = Stadium.Wave("codewars");

            foreach (var wave in waveList)
            {
                Console.WriteLine(wave);
            }
        }
    }
    public class Stadium
    {
        public static List<string> Wave(string str)
        {
            List<char> wave = new List<char>();
            for (int i = 0, j = 0; j < Math.Pow(str.Length, 2) - 7;j++)
            {
                if (j % 8 == 0)
                {
                    wave.Add(char.ToUpper(str[i]));
                    i++;
                }
                else if (str[i] != str[i - 1])
                    wave.Add(str[i]);
            }
            List<string> strList = new List<string>();
            string tempStr = "";
            for (int i = 0; i < wave.Count; i++)
            {
                tempStr += wave[i];
            }
            strList.Add(tempStr);
            return strList;
        }
    }
}
