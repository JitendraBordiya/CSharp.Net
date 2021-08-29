using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet
{
    class Class1
    {
        static void Main(string[] args)
        {
            int a = 66;
            int b = 27;
            int c = a + b;
            Console.WriteLine("The Value of First Variable is{0}", a);
            Console.WriteLine("The Value of First Variable is " + b);
            Console.WriteLine("The Addition of{0} and {1} = {2}", a, b, c);
            Console.WriteLine("{0} is the total of {1} and {2} ", c, a, b);
            Console.Read();
        }
    }
}
