using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Xml.Linq;

namespace StadiumWave
{
    class Program
    {
        static void Main(string[] args)
        {
            Kata kata = new Kata();
            List<string> waveList = kata.Wave("two words");

            foreach (var wave in waveList)
            {
                Console.WriteLine(wave);
            }
        }
    }
    public class Kata
    {
        public List<string> Wave(string str)
        {
            if (str == "")
            {
                List<string> emptyList = new List<string>();
                return emptyList;
            }

            bool fix = false;

            if (str[str.Length - 1] == 32)
            {
                str = str.TrimEnd(' ');
                fix = true;
            }

            List<char> wave = new List<char>();
            char[] strChar = str.ToCharArray();
            double limit = Math.Pow(str.Length, 2);
            for (int i = 0, j = 0; j <= limit; j++)
            {
                if (j == limit || j % 8 == 0)
                {
                    while (strChar[i] == 32 && strChar[strChar.Length - 1] != 32)
                        i++;

                    strChar[i] = char.ToUpper(strChar[i]);
                    wave.AddRange(strChar);
                    if (fix == true)
                    {
                        wave.Add(' ');
                        wave.Add(',');
                    }
                    else
                        wave.Add(',');
                    strChar[i] = char.ToLower(strChar[i]);
                    if (i < strChar.Length - 1)
                        i++;
                    else
                        j = (int)limit;
                }
            }

            if (wave[wave.Count - 1] == ',')
                wave.RemoveAt(wave.Count - 1);

            string tempStr = null;

            for (int i = 0; i < wave.Count; i++)
                tempStr += wave[i];

            var finalTemp = tempStr.Split(',');
            List<string> strList = finalTemp.ToList();
            return strList;
        }
    }
}