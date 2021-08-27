using System;

namespace DemoParams7
{
    class Pocket
    {
        public int Multiply(params int[] Coins)
        {
            int total = 1;
           foreach(int i in Coins)
            {
                total *= i;

            }
            return total;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
           Pocket b1 = new Pocket();
            Console.WriteLine("Total Coins In Pocket = "+b1.Multiply(11, 4));
            Console.WriteLine("Total Coins In Pocket = "+b1.Multiply(11, 4, 6));
            Console.WriteLine("Total Coins In Pocket = "+b1.Multiply(11, 4, 6, 90));
            Console.Read();


        }
    }
}
