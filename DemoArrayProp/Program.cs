using System;

namespace DemoArrayProp
{
    class Perform
    {
       public void ArrProp(int[] myArray)
        {
            int length = myArray.Length;
            int rank = myArray.Rank;
            Console.WriteLine("The length of the Array is : " + length);
            Console.WriteLine("The Rank of the Array is : " + rank);
            Console.WriteLine("The Size of Array is Fixed : " +myArray.IsFixedSize);
            Console.WriteLine("The Array is ReadOnly or not : " + myArray.IsReadOnly);
            Console.WriteLine("The Array is ReadOnly or not : " + myArray.IsSynchronized);
            

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Perform p1 = new Perform();
            Console.WriteLine("Enter Size of Array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] myArray = new int[n];
            Console.WriteLine("Enter Elements in Array");
            for (int i = 0; i < n; i++)
            { 
                myArray[i] = Convert.ToInt32(Console.ReadLine());
               }
            p1.ArrProp(myArray);
            Console.ReadKey();

        }
    }
}
