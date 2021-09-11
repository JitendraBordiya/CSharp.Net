using System;

using System.Collections.Generic;
namespace LambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {

          
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<int> evenNumbers = list.FindAll(x => (x % 2) == 0);
            List<int> oddNumber = list.FindAll(x => (x % 2) != 0);
            Console.Write("List Of EvenNumbers : ");
          foreach (var num in evenNumbers)
                             {
                  Console.Write("{0} ", num);
                            }
            Console.WriteLine();
            Console.Write("List Of oddNumber : ");
            foreach (var obj in oddNumber)
            {
                Console.Write("{0} ", obj);
            }
            Console.WriteLine();
                Console.Read();
         }
    }
}
