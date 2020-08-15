using System;

namespace FindVowel
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Please enter a string to test for vowels: ");
            int vowelCount = Kata.GetVowelCount(Console.ReadLine());
            System.Console.WriteLine($"The vowel count is {vowelCount}");
        }
    }
public static class Kata
{
    public static int GetVowelCount(string str)
    { // a, e, i, o, u
        int vowelCount = 0;

        char[] arr = str.ToCharArray();

        for (int i = 0; i < str.Length; i++)
        {
            switch (arr[i])
            {
                case ('a'):
                vowelCount++;
                break;
                case ('e'):
                vowelCount++;
                break;
                case ('i'):
                vowelCount++;
                break;
                case ('o'):
                vowelCount++;
                break;
                case ('u'):
                vowelCount++;
                break;
                default:
                break;
            }
        }

        return vowelCount;
    }
}

}
