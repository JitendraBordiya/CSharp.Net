using System;

namespace Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arithmetic 
            int a = 22;
            int b = 33;
            int d = 33;
           int  sum = a + b;
            Console.WriteLine("The Value of first variable is {0} ", a);
            Console.WriteLine("The Value of Second variable is "+b);
            Console.WriteLine("The Addition of {0} and{1} = {2} ",a,b,sum);
            Console.WriteLine("{0} is the total of {1} and {2} ",sum,a,b);

            Console.WriteLine("");
            //pre and post Increment
            int c = a++;
            Console.WriteLine("The value of a++ is " + c);
            c = a++;
            Console.WriteLine("The value of ++a is " + c);
            c = ++b;
            Console.WriteLine("The value of ++b is " + c);
            c = b++;
            Console.WriteLine("The value of b++ is " + c);
            c = b--;
            Console.WriteLine("The value of b-- is " + c);
            c = --b;
            Console.WriteLine("The value of --b is " + c);
           
            Console.WriteLine("");
            //Logical And && Logical OR ||
            Console.WriteLine(a > b && b == d);
            Console.WriteLine(a > b || b==d);


            //if  else nested
            Console.WriteLine("");
            if (a<b)
            {
                if (b == d)
                {
                    Console.WriteLine("b is equal to d");
                }
                else
                {
                    Console.WriteLine("b is not equal to d");
                }
            }
            else
            {
                Console.WriteLine("a greater than b");
            }




            Console.Read();






        }
    }
}
