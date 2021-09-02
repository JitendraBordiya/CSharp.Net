using System;
using System.IO;

namespace DemoFileIO
{
    class FileOp
    {
        public void WriteData()
        {
            FileStream fs=new FileStream(@"C:\File IO\Student.txt",FileMode.Create,FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            string str = Console.ReadLine();
            sw.WriteLine(str);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        public void ReadData()
        {
            FileStream fs = new FileStream(@"C:\File IO\Student.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr= new StreamReader(fs);
            String str = " ";
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            while (str != null)
            {
                Console.WriteLine(str);
                str = sr.ReadLine();
            }
            
            sr.Close();
            fs.Close();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FileOp fn= new FileOp();
            fn.WriteData();
            fn.ReadData();
        }
    }
}
