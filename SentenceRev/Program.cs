using System;

namespace SentenceRev
{
    class Program
    {
        public static void SentenceRev(string str)
         {

             string[] str1 = str.Split(" ");
             string rev = " ";
             for (int i = str1.Length - 1; i >= 0; i--)
             {
                 rev += str1[i] + " ";
             }
             Console.WriteLine(rev);
         }
         
        public static void Rev(string str2)
        {
            char[] str = str2.ToCharArray();
            char[] Result = new char[str.Length];
            for (int i = 0, j = str2.Length - 1; i < str2.Length; i++, j--)
            {
                Result[i] = str[j];
            }
            string rev = new string(Result);
            Console.WriteLine(rev);
        }
        static void Main(string[] args)
        {
            string str = "A World Smallest Power is Power  of Ant";
            string str2 = "Jitendra";
            Program.Rev(str2);
            Program.SentenceRev(str);

        }
    }
}
