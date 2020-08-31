using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ListFiltering
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> list = new List<object> { 1, 2, "aasf", "1", "123", 123 };
            //List<object> list = new List<object> { "a", "b", 1 };
            Filter.GetIntegersFromList(list);
            foreach (var num in list)
            {
                Console.WriteLine(num);
            }

        }
    }
}
