using System;

namespace DemoInheritance
{
    class Animal
    {
        public virtual void FoodHabits()
        {
            Console.WriteLine("Animal Eat meat As Well as Plants");
        }
        // Using sealed KeyWord
        /*public sealed  virtual void Behave()
        {
            Console.WriteLine("They behave Diffrently");

        }*/
               }
    class Cornivorus : Animal
    {
        public override void FoodHabits()
        {
            Console.WriteLine("They eat only meat");
        }
      
        //if any method Sealed it cannot Override

      /* public override void Behave()
        {

        }
      */
    }
    class Omnivorus : Animal
    {
        public override void FoodHabits()
        {
            Console.WriteLine("They eat only Plants");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal ar = new Animal();
            ar.FoodHabits();
            Cornivorus cr = new Cornivorus();
            cr.FoodHabits();
           
            Omnivorus or = new Omnivorus();
            or.FoodHabits();
            Console.ReadKey();
          
            
        }

    }
}
