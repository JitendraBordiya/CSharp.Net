using System;

namespace DemoCountUniqueArray
{
    class UniqueCount
    {
        public void Count(int[] arr)
        {
            int temp =0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; i < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Console.WriteLine("Duplicated  Arrays are " + arr[j]);
                        break;
                       
                    }

                }
            }
            Console.WriteLine("The Total Number of Unique Value is Array is " + temp);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            UniqueCount r1 = new UniqueCount();
            int[] arr = new int[]{10, 20, 30, 40, 50, 20, 10, 50, 20, 10};
            r1.Count(arr);
        }
    }
}
