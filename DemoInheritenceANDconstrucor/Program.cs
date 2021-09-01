using System;

namespace DemoInheritenceANDconstrucor
{
    class Student
    {
        private int Rollno;
        private string firstName;
        public  Student(int Rollno, string firstName)
        {
            this.Rollno = Rollno;
            this.firstName = firstName;
        }
        
        public void Printdetails()
        {

             Console.Write("Roll No : {0}", Rollno," \t");
             Console.Write(" First Name : {0}", firstName," \t");
        }

    }
    class HostelStudent : Student {
        private int roomNo;
        public HostelStudent(int Rollno,string firstName,int roomNo) : base( Rollno,firstName)
        {
            this.roomNo = roomNo;
        }
      
        public  void printdetails()
        {

            base.Printdetails();
            Console.Write(" Room No : {0} ",roomNo);
        }
    
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------Student Details-----------");
            HostelStudent hs1 = new HostelStudent(111,"Rajiv",12);
            HostelStudent hs2 = new HostelStudent(222, "Sarvan", 13);
            hs1.printdetails();
            Console.WriteLine();
            hs2.printdetails();
        }
    }
}
 