using System;

namespace PalindromeCheck
{
    class Program
    {
        public static void Check(string str)
            {
            char[] ch1 = str.ToCharArray();
            char[] ch2 = new char[str.Length];
            
            for(int i=0,j=str.Length-1;i<str.Length;i++,j--)
            {
                ch2[i] = ch1[j];
            }
            string rev = new string(ch2);
            Console.WriteLine(str.Equals(rev) ? "Palindrome" : "Not Palindrome");
            }
        static void Main(string[] args)
        {
            string str = "NAYAR";
            string str1 = "NAYAN";
            string str2 = "KALYAN";
            string str3 = "RACECAR";
            Program.Check(str);
            Program.Check(str1);
            Program.Check(str2);
            Program.Check(str3);

        }
    }
}
