using System;

namespace Demo3
{
    class Program
    {
        static void Main(string[] args)
        { 
            int a, b;
            int d;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("xxxxxxxxxxxxxxxx----CALCULATOR-----xxxxxxxxxxx");
            Console.Write("Enter The Value of A :");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter The Value of B : ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("PRESS ANY Character To Perform Operation  : ");
            char c = Convert.ToChar(Console.ReadLine());

            switch (c)
            {
                case 'A':
                    d = a + b;
                    Console.WriteLine("The Addition Value of {0} and {1} = {2} ", a, b, d);
                    break;
                case 'S':
                    d = a - b;
                    Console.WriteLine("The Subtraction Value of {0} and {1} = {2} ", a, b, d);
                    break;
                case 'G':
                    d = a * b;
                    Console.WriteLine("The Multiplication Value of {0} and {1} = {2} ", a, b, d);
                    break;
                case 'D':
                    d = a / b;
                    Console.WriteLine("The Divide Value of {0} and {1} = {2} ", a, b, d);
                    break;
                case 'M':
                    d = a % b;
                    Console.WriteLine("The Modulous Value of {0} and {1} = {2} ", a, b, d);
                    break;
                default:
                    Console.WriteLine("Instructions");
                    Console.WriteLine("Press A for Addition");
                    Console.WriteLine("Press S for Subtraction");
                    Console.WriteLine("Press D for Divide");
                    Console.WriteLine("Press G for Multiply");
                    Console.WriteLine("Press M for Modulous");
                    break;

            }
            Console.Write("xxxxxxxxxxxxxxxx----CALCULATOR-----xxxxxxxxxxx");

            Console.Read();


        }
    }
}
