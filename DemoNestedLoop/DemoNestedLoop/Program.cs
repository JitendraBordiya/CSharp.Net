using System;

namespace DemoNestedLoop
{
    class Pattern1
    { 
        public void Pat1(int num)
        {
            int i, j;
            int number;
            for( i = 0; i < num; i++)
            {
                number = 1;
                for (j = 0; j <=i; j++)
                {
                    Console.Write(number);
                    number++;
                }
                Console.WriteLine(" ");
                
            }
        }
        public void Pat2(int num)
        {
            int i, j;
            int number;
            for (i = 0; i<num; i++)
            {
                number = 5;
                for (j = 0; j <= i; j++)
                {
                    Console.Write(number);
                    number--;
                }
                Console.WriteLine(" ");

            }
        }
        public void Pat3(int num)
        {
            int i, j;
            int number;
            for (i = num; i > 0; i--)
            {
                number = 5;
                for (j = 0; j <i; j++)
                {
                    Console.Write(number);
                    number--;
                }
                Console.WriteLine(" ");

            }
        }
    }
     class Program
    {
        static void Main(string[] args)
        {
            Pattern1 p = new Pattern1();
            p.Pat3(5);
          
        }
    }
}
