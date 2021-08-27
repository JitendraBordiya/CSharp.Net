using System;

namespace DemoNamedArguement
{
    class Product
    {
        public void PrintOrderDetails(string Sname,int Pid,string Pname)
        {
            Console.WriteLine(Sname + ":" + Pid + ":" + Pname);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            p1.PrintOrderDetails(Sname: "SV Gift Shop", Pid: 11, Pname: "Barbie Doll");
            p1.PrintOrderDetails(Sname: "Raju Mobile Shop", Pid: 22, Pname: "Cell Phone");
            p1.PrintOrderDetails(Sname: "S.N pet Shop", Pid: 33, Pname: "White Mice");
        }
    }
}
