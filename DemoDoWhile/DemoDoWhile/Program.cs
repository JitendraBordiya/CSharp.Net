using System;

namespace DemoDoWhile
{
    class Also
    {
        public void Check(int n)
        {
            int i = 0;
            int j = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= n);
        
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Also a = new Also();
            Console.Write("Enter The Value of N : ");
            int num = Convert.ToInt32(Console.ReadLine());
            a.Check(num);
        

        }
    }
}
