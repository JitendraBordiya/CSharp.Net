using System;
using System.Collections;

namespace DemoArrayListInsert
{
    class InsertArrayList
    {

        ArrayList List1 = new ArrayList();
        ArrayList List2 = new ArrayList();
        public void Insert()
        {
            List2.Add(600);
            List2.Add(700);
            List2.Add(800);
            List2.Add(900);
            List2.Add(1000);

            List1.InsertRange(6, List2);
            
            
            List1.Add(100);
            List1.Add(200);
            List1.Add(300);
            List1.Add(400);
            List1.Add(500);
            foreach(int i in List1)
            {
                int length = List1.Count;
                int Size = List1.Capacity;
                Console.WriteLine(length);
                Console.WriteLine(Size);
                Console.WriteLine("The Elements in List1 {0} ", i);
            }

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            InsertArrayList in1= new InsertArrayList();
             in1.Insert();
           
        }
    }
}
