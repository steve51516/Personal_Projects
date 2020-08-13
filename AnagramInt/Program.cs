using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramInt
{
    class Program
    {
        static void Main(string[] args)
        {
            Anagram anagram = new Anagram();

            string[] vs = { "dite", "edit", "tide", "tied"};
            anagram.IsAnagram("diet", vs);
        }
    }
    class Anagram
    {
        public void IsAnagram(string word, string[] vs)
        {
            int totalWord = 0;
            for (int i = 0; i < word.Length; i++)
            {
                    System.Console.WriteLine($"totalWord is now {totalWord}");
                    totalWord += 0 + word[i];
            }
            int vsWord0 = 0;
            int vsWord1 = 0;
            int vsWord2 = 0;
            int vsWord3 = 0;

            for (int i = 0; i <= vs.Length - 1; i++)
            {
                vsWord0 += vs[0][i];
                vsWord1 += vs[1][i];
                vsWord2 += vs[2][i];
                vsWord3 += vs[3][i];

            }
            Console.WriteLine($"vsWord0: {vsWord0}\n vsWord1: {vsWord1}\n vsWord2: {vsWord2}\n vsWord3: {vsWord3}");
            if (totalWord == vsWord0)
                Console.WriteLine($"{word} and {vs[0]} are anagrams.");
            else
                Console.WriteLine($"{word} and {vs[0]} are not anagrams.");
            if (totalWord == vsWord1)
                Console.WriteLine($"{word} and {vs[1]} are anagrams.");
            else
                Console.WriteLine($"{word} and {vs[1]} are not anagrams.");
            if (totalWord == vsWord2)
                Console.WriteLine($"{word} and {vs[2]} are anagrams.");
            else
                Console.WriteLine($"{word} and {vs[2]} are not anagrams.");
            if (totalWord == vsWord3)
                Console.WriteLine($"{word} and {vs[3]} are anagrams.");
            else
                Console.WriteLine($"{word} and {vs[3]} are not anagrams.");
        }
    }
}
