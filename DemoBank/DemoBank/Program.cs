using System;

namespace DemoBank
{
    class Bank
    {
        
        public void Details(String Cname,int Wamount,int balance)
        {
            Console.WriteLine("User_Name : "+Cname+" And " +"your Balance : "+(Wamount > balance ? (balance) : (balance- Wamount)));

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bank b1 = new Bank();
            b1.Details("Rajiv",1,10000);
        }
    }
}
