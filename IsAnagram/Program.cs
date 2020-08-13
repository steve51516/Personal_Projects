using System;
using System.Linq;
using System.Net.NetworkInformation;

namespace IsAnagram
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayA = { "diet", "edit", "tide", "tied" };

            Anagram.IsAnagram("deit", arrayA);
            
        }
    }
    class Anagram
    {
        public static bool IsAnagram(string word1, string[] arrA)
        {
            lengthCheck(word1, arrA);
            //TODO create method that will reduce repetition of tested char arrays

            Array.Sort(arrA);
            //char[] strWrd1 = word1.ToCharArray();
            char[] elem0 = srtConvArr(arrA[0]);
            char[] elem1 = srtConvArr(arrA[1]);
            char[] elem2 = srtConvArr(arrA[2]);
            char[] elem3 = srtConvArr(arrA[3]);
            
            // Tests char array elem1 against test word
            for (int i = 0; i <= elem1.Length - 1; i++)
            {
                if (elem1[i] != word1[i])
                {
                    Console.WriteLine($"{arrA[0]} and {word1} are not anagrams.");
                    return false;
                }
            }
            return true;
        }
        static bool lengthCheck(string word1, string[] arrA)
        {
            for (int i = 0; i <= arrA.Length - 1; i++)
            {
                if (word1.Length != arrA[i].Length)
                {
                    Console.WriteLine($"{word1} is {word1.Length} characters long and {arrA[i]} is {arrA[i].Length} characters long");
                    Console.WriteLine($"\n{word1} and {arrA[i]} cannot be anagrams");
                    return false;
                }
            }
            Console.WriteLine($"All words in array are equal to {word1.Length}");
            return true;
        }
        static char[] srtConvArr(string str)
        {
            char[] arr = str.ToArray();
            Array.Sort(arr);
            return arr;
        }
        
    }
}

