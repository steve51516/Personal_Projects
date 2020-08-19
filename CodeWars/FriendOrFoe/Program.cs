using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendOrFoe
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Ryan", "Kieran", "Mark" };
            string[] friends = (string[])Kata.FriendOrFoe(names);
            foreach (string name in friends)
            {
                Console.WriteLine(name);
            }
        }
    }
    class Kata
    {
        public static IEnumerable<string> FriendOrFoe(string[] names)
        {
            int friendCount = 0;
            for (int i = 0; i <= names.Length - 1; i++)
            {
                if (names[i].Length == 4)
                    friendCount++;
            }
            int j = 0;
            string[] friends = new string[friendCount];
            for (int i = 0; i <= names.Length - 1; i++)
            {
                if (names[i].Length == 4)
                {
                    friends[j] = names[i];
                    j++;
                }
            }
            return friends;
        }
    }
}
