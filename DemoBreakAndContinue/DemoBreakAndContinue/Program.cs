using System;

namespace DemoBreakAndContinue
{
    class A
    {
       public void Br(int n)
        {
            for(int i = 0; i <= n; i++)
            {
                if (i == 5){
                    break;
                }
                Console.WriteLine(i);
            }
        }
        public void Con(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                if(  i < 5)
                {
                    continue;
                 }
                Console.WriteLine(i);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            Console.WriteLine("OutPut for Break");
            a.Br(10);
            Console.WriteLine("OutPut for Continue");
            a.Con(10);
        }
    }
}
