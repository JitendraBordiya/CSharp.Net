using System;
using System.Collections.Generic;

namespace DupValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {

                int[] arr = { 1, 2, 2, 3, 1, 5, 9, 20, 33, 5, 2 };
                Dictionary<int, int> map = new Dictionary<int, int>();
                foreach (int c in arr)
                {
                    if (map.ContainsKey(c))
                    {
                        map[c] = map[c] + 1;
                    }
                    else
                    {
                        map.Add(c, 1);
                    }
                }
                var s1 = new HashSet<int>(map.Keys);
                foreach (int s in s1)
                {
                    if (map[s] > 1)
                    {
                        Console.WriteLine($"The Reapeating Value {s} comes {map[s]}");
                    }
                }
            
        }
    }
}
