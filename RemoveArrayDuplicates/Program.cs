using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveArrayDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {4,5,7,6};
            /*int[] dist = arr.Distinct().ToArray();
            Console.WriteLine(dist.Length);
            Console.WriteLine(arr.Length);
            */
            var dist = new HashSet<int>(arr);
         
            foreach (int i in dist)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
