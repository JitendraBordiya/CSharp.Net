using System;

namespace DemoFactorial
{
    class Factorial
    {
        public static int  Fact(int n)
        {
            int fact = 1;
            for(int i = 1; i <=n; i++)
            {
                fact = fact*i;
            }
            return fact;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("Enter The Number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("The Factorial of " + n + " is " + Factorial.Fact(n));
            Console.ReadKey();
        }
    }
}
