using System;
using System.Linq;
namespace LiNQDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = {"Jitendra","Rishabh"," Rajan"};

            var query = from name in names
                        select name;
         foreach(var n in query)
            {
                Console.WriteLine(n);
            }
        }
    }
}
