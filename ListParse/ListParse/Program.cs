using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace List_Parse
{
    class Program
    {
        static void Main(string[] args)
        {
            ListFilter filter = new ListFilter();
            filter.CountSort('a', 'b', 'c', 'c', 'd', 'e', 'e', 'e', 'f', 'g', 'g');
        }
    }

    class ListFilter
    {
        public void CountSort(params char[] vs)
        {
            int b;
                for (int j = 0; j <= vs.Length - 1; j++)
                {
                    b = j + 1;
                    do
                    {
                    if (vs[j] == vs[b])
                            Console.WriteLine($"{vs[j]} is equal to {vs[b]}");
                    if (b < vs.Length - 1)    
                        b++;
                    } while (b <= vs.Length - 1);

            }
        }
    }
}
