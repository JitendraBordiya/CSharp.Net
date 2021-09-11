using System;

namespace ExtensionMethod
{
    class Flower
    {
        public  void Lily(){
            Console.Write(" National Flower is Lily");
            
           }
        public  void Jasmine()
        {
            Console.Write("National Flower is Jasmine");
             }
    }
   static class  Country
    {
        public static void England(this Flower F)
        {
            Console.Write("This is England and ");
        }
        public static void France(this Flower F)
        {
            Console.Write("This is France and ");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Flower f1 = new Flower();
           
           
            f1.England();
            f1.Lily();
            Console.WriteLine();
            f1.France();
            f1.Jasmine();
            Console.Read();


        }
    }
}
