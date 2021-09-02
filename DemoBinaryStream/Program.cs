using System;
using System.IO;

namespace DemoBinaryStream
{

    class BinaryTesting
    {
        FileStream fs;
        int i;
        string n;
        double f;
        public BinaryTesting()
        {
            i = 12;
            n = "geeta";
            f = 34.4F * 34.5F;
        }
        public void WriteData()
        {
            fs = new FileStream(@"C:\File IO\Binary.Dat", FileMode.Create, FileAccess.ReadWrite);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(i);

            bw.Write(f);
            bw.Write(n);

            bw.Flush();
            bw.Close();
        }
        public void ReadData()
        {
            int i;
            double f;
            string n;
            fs = new FileStream(@"C:\File IO\Binary.Dat", FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            i = br.ReadInt32();
            f = br.ReadDouble();
            n = br.ReadString();
            Console.WriteLine("Integer data :{0}", i);
            Console.WriteLine("String data :{0}", n);
            Console.WriteLine("Double data :{0}", f);
            br.Close();
            fs.Close();
        }
    }
    public class Program
    {
         static void Main(string[] args)
        {
            BinaryTesting bn = new BinaryTesting();
            bn.WriteData();
            bn.ReadData();
        }
    }

}
