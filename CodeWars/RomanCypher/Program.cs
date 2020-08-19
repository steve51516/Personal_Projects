using System;
using System.Text;

namespace RomanCypher
{
    class Program
    {
        static void Main(string[] args)
        {
            string cryptoString = Kata.CryptAlpha("The quick brown fox jumps over the 2 lazy dogs");
            string decryptString = Kata.CryptAlpha("Gur dhvpx oebja sbk whzcf bire gur 7 ynml qbtf");

            Console.WriteLine(cryptoString);
            Console.WriteLine(decryptString);
        }
    }
    class Kata
    {
        static public string CryptAlpha(string text)
        {
            char[] vs = text.ToCharArray();

            for (int i = 0; i <= vs.Length - 1; i++)
            {
                if (vs[i] >= 65 && vs[i] <= 90)
                {
                    if (vs[i] >= 78)
                    {
                        vs[i] -= (char)13;
                    }
                    else
                        vs[i] += (char)13;
                }
                else if ((int)vs[i] >= 97 & (int)vs[i] <= 122)
                {
                    if (vs[i] >= 110)
                    {
                        vs[i] -= (char)13;
                    }
                    else
                        vs[i] += (char)13;
                }
            }

            StringBuilder builder = new StringBuilder();

            foreach (char value in vs)
            {
                builder.Append(value);
            }
            string result = builder.ToString();
            char[] vs1 = CryptNumeric(result);
            foreach (char value in vs1)
            {
                builder.Append(value);
            }
            string finalResult = builder.ToString();
            return finalResult;
        }
        static public char[] CryptNumeric(string text)
        {
            char[] vs = text.ToCharArray();
            for (int i = 0; i <= vs.Length - 1; i++)
            {
                if (vs[i] >= 48 && vs[i] <= 57)
                {
                    if (vs[i] >= 53)
                        vs[i] -= (char)5;
                    else
                        vs[i] += (char)5;
                }
            }
            return vs;
        }
    }
}