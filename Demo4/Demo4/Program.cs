using System;

namespace Demo4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 3;
            int c = 8;
            if((a>b)&& (a > c))
                {
                Console.WriteLine("The {0} is Greater than {1} and {2}",a,b,c);
                  }
            else if ((b>c) && (b>a))
                {
                Console.WriteLine("The {0} is Greater than {1} and {2}", b, a, c);
                }
            else
                    {
                Console.WriteLine("The {0} is Greater than {1} and {2}", c, a, b);
            }
        }
    }
}
