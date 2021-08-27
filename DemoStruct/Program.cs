using System;

namespace DemoStruct
{
   public struct Person
    {
        public String name;
        public int Age;
        public int weight;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p1;
            p1.name = "Jitendra";
            p1.Age = 24;
            p1.weight = 60;
            Console.WriteLine("The Deitals of Person Is Name = "+p1.name+" Age = "+p1.Age+" Weigtht = "+p1.weight);
        }
    }
}
