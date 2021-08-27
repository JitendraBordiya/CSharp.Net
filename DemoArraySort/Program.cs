using System;

namespace DemoArraySort
{
    class Sort
    { 

        public void AscSort(int[] a)
        {
            int temp = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }

            }
            for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i] + " ");
            }
        }
        public void DescSort(int[] a)
        {
            int temp = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] < a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }

            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i] + " ");
            }
        }
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            Sort s1 = new Sort();
            int[] a = new int[] { 5, 7, 2, 4, 6, 8, 1 };
            Console.WriteLine("The Array is Printed in Ascending Order");
            s1.AscSort(a);
            Console.WriteLine("The Array is Printed in Descending Order");
            s1.DescSort(a);
        }
    }
}
