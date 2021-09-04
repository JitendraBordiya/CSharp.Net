using System;
using System.IO;
using System.Collections;
namespace StudentsResultApp
{
    
        class Student
        {
            string Name;
            int[] subjectMarks = new int[3];
            int numOfStudents = 0;
            int avgMarks;

            int total = 0;

            public void BinaryWData()
            {
                Char ans;

                FileStream fs = new FileStream(@"C:\File IO\Stud2.Dat", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);

                do
                {

                    Console.Write("Enter Your Name : ");
                    Name = Console.ReadLine();
                    bw.Write(Name);
                    for (int i = 0; i < 3; i++)
                    {
                        if (i == 0)
                        {
                            Console.Write(" Subject 1 : ");
                        }
                        else if (i == 1)
                        {
                            Console.Write(" Subject 2 : ");
                        }
                        else
                        {
                            Console.Write(" Subject 3 : ");
                        }

                        subjectMarks[i] = Convert.ToInt32(Console.ReadLine());
                        bw.Write(subjectMarks[i]);
                        total += subjectMarks[i];
                    }
                    avgMarks = total / 3;
                    Console.WriteLine(avgMarks);
                    bw.Write(avgMarks);
                    total = 0;
                    Console.WriteLine("Do You Wish To Continue Press Y");
                    ans = Convert.ToChar(Console.ReadLine());
                    numOfStudents++;
                } while (ans == 'Y' || ans == 'y');

                bw.Flush();
                bw.Close();
                fs.Close();

            }
            public void BinaryRData()
            {
              FileStream fs = new FileStream(@"C:\File IO\Stud2.Dat", FileMode.Open, FileAccess.Read);

               BinaryReader br = new BinaryReader(fs);

               for( int j=0;j<numOfStudents;j++)
                {
                    Name = br.ReadString();
                  Console.Write("StudentName : {0}  ", Name);
                  for (int i = 0; i < 3; i++)
                    {
                        subjectMarks[i] = br.ReadInt32();
                      Console.Write("\t " + subjectMarks[i]);
                 }
               avgMarks = br.ReadInt32();
                    Console.WriteLine("\t Percentage : {0} ", avgMarks);
                }

                br.Close();
                  fs.Close();
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Student s = new Student();
                s.BinaryWData();
                s.BinaryRData();
                Console.ReadKey();


            }
        }
    }


