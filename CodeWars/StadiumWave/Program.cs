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
            List<string> waveList = Stadium.Wave("gap");

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
            char[] strChar = str.ToCharArray();
            for (int i = 0, j = 0; j <= Math.Pow(str.Length, 2); j++)
            {
                if (j == Math.Pow(str.Length, 2) || j % 8 == 0)
                {
                    strChar[i] = char.ToUpper(strChar[i]);
                    wave.AddRange(strChar);
                    wave.Add(',');
                    strChar[i] = char.ToLower(strChar[i]);
                    i++;
                }
            }
            string tempStr = "";
            for (int i = 0; i < wave.Count; i++)
            {
                tempStr += wave[i];
            }
            var vs = tempStr.Split(',');
            List<string> strList = vs.ToList();
            return strList;
        }
    }
}