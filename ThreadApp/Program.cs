using System;
using System.IO;
using System.Threading;

namespace ThreadApp
{
    class FileInfo
    {
        public void DataW()
        {
            FileStream fs = new FileStream(@"C:\File IO\count.Dat", FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
                lock (this)
                {
                for (int i = 0; i < 10; i++)
                {

                    bw.Write(i);
                    
                }
            }
                
                bw.Flush();
                bw.Close();
                fs.Close();
            }
               public void DataR()
              {
                FileStream fs = new FileStream(@"C:\File IO\count.Dat", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                for (int i = 0; i < 10; i++)
                {
                    i = br.ReadInt32();
                    Console.WriteLine(i);
                }

                br.Close();
                fs.Close();
              }
        }

        class Program
        {
            static void Main(string[] args)
            {
                FileInfo f1 = new FileInfo();
                ThreadStart ts1 = new ThreadStart(f1.DataW);
                ThreadStart ts2 = new ThreadStart(f1.DataR);
                Thread t1 = new Thread(ts1);
                Thread t2 = new Thread(ts2);
                t1.Start();
                t1.Join();
                t2.Start();
                t2.Join();

        }
        }
  }
