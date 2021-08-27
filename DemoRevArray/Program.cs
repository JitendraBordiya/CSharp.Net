using System;

namespace DemoRevArray
{
    class RevArray
    {
        public void Rev(int[] arr)
        {
            Console.WriteLine("The Original Array");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine( arr[i] + " ");
            }
            Console.WriteLine("The Reverse Array");
            for (int i = arr.Length-1; i >= 0; --i)

            {
                Console.WriteLine( arr[i] + " ");
            }
        }
    }
    class Program
    {
       static void Main(string[] args)
        {
            RevArray r1 = new RevArray();
            int[] arr = new int[] { 2, 4, 6, 8, 10, 12, 14 };
            r1.Rev(arr);
        }
    }
}
