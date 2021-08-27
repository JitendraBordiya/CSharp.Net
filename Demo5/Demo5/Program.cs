using System;

namespace Demo5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Play With Color Activity");
            Console.WriteLine();
            String c1, c2;
            c1 = Console.ReadLine();
            c2 = Console.ReadLine();

            if ((c1=="RED" && c2=="GREEN") || (c1=="GREEN" && c2=="RED"))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Yellow");
            }
            else if ((c1 == "RED" && c2 == "BLUE") || (c1 == "BLUE" && c2 == "RED"))
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Magenta");
            }
            else if ((c1 == "GREEB" && c2 == "BLUE") || (c1 == "BLUE" && c2 == "GREEN"))
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Cyan");
            }
            else
            {
                Console.WriteLine("Incorrect Color");
            }
            Console.ReadLine();
        }
    }
}
