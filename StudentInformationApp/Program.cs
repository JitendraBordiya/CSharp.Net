using System;
using System.Collections;
using System.IO;

namespace StudentInformationApp
{
    class Student
    {
      public void WriteData()
        {
            Char ans;
            string Name;
            int Marks;
            FileStream fs = new FileStream(@"C:\File IO\Stud.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            do
            {
                Console.Write("Enter Your Name : ");
                Name = Console.ReadLine();
                Console.Write("Enter Your Marks : ");
                Marks = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                sw.Write(Name);
                sw.Write(" = ");
                sw.Write(Marks);
                sw.WriteLine();
                Console.WriteLine("Do You Wish To Continue Press Y");
                ans = Convert.ToChar(Console.ReadLine());
            } while (ans == 'Y');
           
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        public void ReadData()
        {
            string Name;
            int Marks;
            
            FileStream fs = new FileStream(@"C:\File IO\Stud.txt", FileMode.Open, FileAccess.Read);

            StreamReader sr = new StreamReader(fs);


                   Name = sr.ReadToEnd();
            //Marks = Convert.ToInt32(sr.ReadToEnd());
                     Console.WriteLine("Name = Marks");
                     Console.WriteLine(Name);
            
            
               // Console.WriteLine(" Marks :{0} ", Marks);
            sr.Close();
            fs.Close();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
          
            Student s = new Student();
            s.WriteData();
            s.ReadData();
            
          
        }
    }
}
