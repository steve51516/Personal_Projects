using System;
using System.Collections.Generic;
using System.Linq;

namespace ListFiltering
{
    public static class Filter
    {
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            var ints = listOfItems.OfType<int>().ToList();
            return ints;
        }
    }
}
