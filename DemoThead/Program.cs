using System;
using System.Threading;

namespace DemoThead
{
    class ThreadDemo
    {
        public void Count1()
        {
            lock (this)
            {
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine(i);
                    
                    // Thread.Sleep(Timeout.Infinite); //Sleep Method To pause Thread For Some Time
                }
            }
        }
        public static void Count2()
        {
            for (int i =11; i <= 20; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ThreadDemo t = new ThreadDemo();

                ThreadStart ts1 = new ThreadStart(t.Count1);
                Thread t1 = new Thread(ts1);
                //ThreadStart ts2 = new ThreadStart(ThreadDemo.Count2);
                //Thread t2 = new Thread(ts2);
                t1.Priority = ThreadPriority.Highest;
                //t2.Priority = ThreadPriority.Lowest;
                t1.Start();
                

                
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            {
                Console.WriteLine("Exception Can't Handle");
            }

            
            //t1.Interrupt();//interrupt Method Used in Case Of Thread Goes Sleep For Infinite 

           // t1.Join();
            //t2.Start();
           
            //t2.Join();
        }
    }
}
