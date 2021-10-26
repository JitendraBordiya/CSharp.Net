using System;

namespace FindMissingNumInArray
{
    class Program
    {
        public static int FindMissingNum(int[] array)
        {
            int n = array.Length + 1;
            int sumofFirstNnum = n * (n + 1) / 2;
            int actualSum = 0;
            for(int i=0;i<array.Length;i++)
            {
                actualSum += array[i];
            }
            return sumofFirstNnum - actualSum;
        }
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 6, 7, 8 };
            int missingNum = FindMissingNum(array);
            Console.WriteLine($"The Mising Number is {missingNum}");

        }
    }
}
