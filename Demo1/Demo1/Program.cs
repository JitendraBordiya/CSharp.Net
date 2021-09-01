using System;

namespace DotNet
{
    class Program
    {
      static void Main(String[] args)
        {
           //fibonacci Series
            int num1 = 0;
            int num2 = 1;
            int n;
            Console.Write("Enter The Value of n :");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write(num1+" "+num2);

             for(int i = 0; i <= n; i++)
            {
              int num3 = num1 + num2;
            Console.Write(" " + num3);
            num1 = num2;
             num2 = num3;
            }

             //Pattern Program
             Console.WriteLine();
            for(int i = 0; i <= n; i++)
            {
            for(int j = 0; j <= i; j++)
            {

               Console.Write("*");
            }
            Console.WriteLine();
            }

            //Passing Value
            int n1, n2;
            n1 = n2 = 24;
            Console.WriteLine("The Value of First Variable is {0}", n1);
            Console.WriteLine("The Value of First Variable is "+ n2);
            //Bool Operator
            int x = 10;
            bool result = (!(x == 10));
            Console.WriteLine("The Condition is " + result);
          
            


            Console.Read(); }
    }
}
