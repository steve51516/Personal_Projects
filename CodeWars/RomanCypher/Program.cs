using System;
using System.Text;

namespace RomanCypher
{
    class Program
    {
        static void Main(string[] args)
        {
            Cypher cypher = new Cypher();

            string cryptoString = cypher.Decrypt("The quick brown fox jumps over the 2 lazy dogs");

            Console.WriteLine(cryptoString);
        }
    }
    class Cypher
    {
        public string Decrypt(string text)
        {
            
            char[] vs = text.ToCharArray();
            foreach (char letter in vs)
            {
                Console.Write((int)letter + " ");
            }
            for (int i = 0; i <= vs.Length - 1; i++)
            {
                if ((int)vs[i] >= 65 & (int)vs[i] <= 90)
                {
                    if (vs[i] >= 77 && vs[i] <= 90)
                    {
                        //int mod = vs[i] - 90;
                        vs[i] -= (char)13;
                    }
                    else
                        vs[i] += (char)13;
                }
                else if ((int)vs[i] >= 97 & (int)vs[i] <= 122)
                {
                    if (vs[i] >= 110 && vs[i] <= 122)
                    {
                        //int mod = vs[i] - 122;
                        vs[i] -= (char)13;
                    }
                    else
                        vs[i] += (char)13;
                }
            }
            StringBuilder builder = new StringBuilder();
            Console.WriteLine("\n");
            foreach (char value in vs)
            {
                builder.Append(value);
            }
            string result = builder.ToString();
            return result;
        }
    }
}