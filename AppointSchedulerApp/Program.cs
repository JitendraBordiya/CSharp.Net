using System;
using System.IO;

namespace AppointSchedulerApp
{
    class Appointment{
        String Name;
        int date, month, year;
        Double  Time;
        char choice;
        int i = 0;
        public void StoreInfo()
        {
            FileStream fs = new FileStream(@"C:\File IO\Apointment.Dat", FileMode.Create, FileAccess.Write);
            BinaryWriter bw =new  BinaryWriter(fs);
            
            do
            {
                Console.WriteLine("Schedule Your Appointment");
                Console.Write("Enter Your Name : ");
                Name = Console.ReadLine();
                bw.Write(Name);
                
                Console.Write(" Confirm Date : ");
                date = Convert.ToInt32(Console.ReadLine());
                
                bw.Write(date);
                Console.Write(" Confirm Month : ");
                
                month = Convert.ToInt32(Console.ReadLine());
                bw.Write(month);
                
                Console.Write(" Confirm Year : ");
                year = Convert.ToInt32(Console.ReadLine());
                bw.Write(year);
                 
                Console.Write(" Enter Time : "); ;
                Time = Convert.ToDouble(Console.ReadLine());
                bw.Write(Time);
                Console.WriteLine("Want to Schedule More Appointments Press Y");
                choice = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("");
                i++;
            } while (choice == 'Y' || choice == 'y');

            bw.Flush();
            bw.Close();
            fs.Close();
        }
        public void ReadInfo()
        {
            FileStream fs = new FileStream(@"C:\File IO\Apointment.Dat", FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            for (int j = 0; j <=i; j++)
            {
                
                
                    Name = br.ReadString();
                    Console.Write("Name :"+Name +" ");
                   date = br.ReadInt32();
                Console.Write(date);
                month = br.ReadInt32();
                Console.Write("-"+month);
                year = br.ReadInt32();
                Console.Write("-"+year);
                Time = br.ReadDouble();
                Console.Write(" "+Time);
                Console.WriteLine();
            }
           
            br.Close();
            fs.Close();


        }



    }
    class Program
    {
        static void Main(string[] args)
        {
            Appointment a1 = new Appointment();
            a1.StoreInfo();
            a1.ReadInfo();
            Console.ReadKey();

        }
    }
}
