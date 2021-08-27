using System;

namespace DemoEnum
{
    class Program
    {
        enum Days { Mon, Tue, Wed, Thu, Fri, Sat, Sun };
        static void Main(string[] args)
        {
            Console.WriteLine("Enum Demo");
            int firstday = (int)Days.Mon;
            int lastday = (int)Days.Sun;
            Console.WriteLine("Mon {0}", firstday);
            Console.WriteLine("Sun {0}", lastday);




        }
    }
}
