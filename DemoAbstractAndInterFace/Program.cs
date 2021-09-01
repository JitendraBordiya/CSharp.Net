using System;

namespace DemoAbstractAndInterFace
{
   public  interface ThreeDShape
    {
        public abstract void draw3D(int l,int b,int h);
    }

    interface TwoDShape
    {
        public abstract void draw2D(int l,int h);
    }
    abstract class Shape
    {
        public abstract int draw(params int [] newArr);
        public void display()
        {
            Console.WriteLine("Calling from shape class");
        }

    }
    // : in csharp defines inherit and implements
    class Rectangle : Shape, ThreeDShape, TwoDShape
    {
        public override int draw(params int[] coins)
        {
            int total = 0;
            foreach(int i in coins)
            {
                total += i;
            }
            return total;
        }

        public  void  draw2D(int l,int b)
        {
            int area = l * b;
            Console.WriteLine("The Area Of Rectangle is {0} ", area);
        }

        public void draw3D(int l,int b,int h)
        {
            int area = l * b * h;
            Console.WriteLine("The Area of Triangle is {0} ", area);
         }

    }
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter The Length");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter The Breadth");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter The Height");
            int h = Convert.ToInt32(Console.ReadLine());
           
            Rectangle r1 = new Rectangle();
            Rectangle r2 = new Rectangle();
            Console.WriteLine("The Total Coins in My Pocket {0} " ,r2.draw(1,2,3,4,5));
            Console.WriteLine("The Total Coins in My Pocket {0} ", r2.draw(1,2,3,4,5,6,7,8,9));
            Console.WriteLine("The Total Coins in My Pocket {0} ", r2.draw(10, 20, 30, 40, 50, 60, 70, 80, 90));
            r1.draw2D(l,b);
            r1.draw3D(l,b,h);
           


        }
    }

}
