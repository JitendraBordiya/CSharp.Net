using System;

namespace DotNet
{
    class Task
    {
        static void Main(string[] args)
        {
            Console.WriteLine("###################SIMPLE CALCULATOR#####################");
            int cal;
            int a, b;
            Console.WriteLine("Enter The Values");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Press Any Special Arithmetic To Perform Operation");
            cal = Convert.ToInt32(Console.ReadLine());

            switch (cal)
            {
                case 1:
                    Console.Write("The Addition Of A and B is " + (a + b));
                    break;
                case 2:
                    Console.Write("The Addition Of A and B is " + (a - b));
                    break;
                case 3:
                    Console.Write("The Addition Of A and B is " + (a * b));
                    break;
                case 4:
                    Console.Write("The Addition Of A and B is " + (a / b));
                    break;
                default:
                    Console.Write("Exit");
                    break;
            }

            Console.WriteLine("--------------------EXIT-------------------------");
        }
    }
}