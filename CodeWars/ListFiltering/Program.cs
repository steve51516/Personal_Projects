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

            var list2 = ListFilterer.GetIntegersFromList(list);
            foreach (var num in list2)
            {
                System.Console.WriteLine(num);
            }

        }
    }
    public class ListFilterer
    {
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            listOfItems.TrimExcess();
            List<int> listOfInts = new List<int>();
            for (int i = 0; i <= listOfItems.Capacity - 1; i++)
            {
                if (listOfItems[i] is int)
                    listOfInts.Add((int)listOfItems[i]);
            }
            return listOfInts;
        }
    }
}
