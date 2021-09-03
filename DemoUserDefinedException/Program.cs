using System;

namespace DemoUserDefinedException
{
    class Addition
    {

        public void Sum(int a, int b)
        {
            if (b == 0 || b >= 10000 && a == 0 || a >= 10000)
            {
                throw (new IntegerOutOfRnge("Values Should be Greater Than Zero Or Less Than TEN Thousand !!"));
            }
            else
            {
                int c = a + b;
                Console.WriteLine("The Sum is " + c);
            }
        }
    }

        public class IntegerOutOfRnge : ApplicationException
    {
       
             
        public  IntegerOutOfRnge(string message):base(message)
            {
              
            }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Addition ad = new Addition();
           
            try
            {
                Console.WriteLine("Enter Two Numbers ");
                Console.Write("A := ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("B := ");
                int b = Convert.ToInt32(Console.ReadLine());
                ad.Sum(a, b);

            }
            catch(IntegerOutOfRnge e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
