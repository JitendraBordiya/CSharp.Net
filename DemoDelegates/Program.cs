using System;

namespace DemoDelegates
{
    public delegate void AddNumbers(int x, int y);
    public delegate void Display(string str);

    class Demo
    {
        public void Sum(int x,int y)
        {
            Console.WriteLine(x + y);
        }
        public void Show(string msg)
        {
            Console.WriteLine("Hello " + msg);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Demo d = new Demo();
            AddNumbers a1 = new AddNumbers(d.Sum);
            Display d1 = new Display(d.Show);
            a1(19, 31);
            d1("Jitendra");
            d1("Rahul");
        
        }
    }
}
