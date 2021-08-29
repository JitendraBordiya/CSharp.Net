using System;

namespace Demo6
{
    class Swap
    {
        //Swap to numbers Using ref Keyword
        public void SwapNum(ref int x,ref int y)
        {
            int z = x;
            x = y;
            y = z;
          }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = 200;
            int b = 300;
            Swap s1 = new Swap();
            Console.WriteLine("Value of a and b before Swapping");
            Console.WriteLine("a =" + " " + a);
            Console.WriteLine("b =" + " " + b);
            s1.SwapNum(ref a, ref b);
            Console.WriteLine("Value of a and b After Swapping");
            Console.WriteLine("a =" + " " + a);
            Console.WriteLine("b =" + " " + b);
            Console.ReadKey();

        }
    }
}
