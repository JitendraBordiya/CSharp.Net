using System;
using System.Collections.Immutable;

namespace StringAnagram
{
public class Anagram
    {
        public void Check(string input1, string input2)
        {
            char[] ch = input1.ToLower().ToCharArray();
            char[] ch1 = input2.ToLower().ToCharArray();
            Array.Sort(ch);
            Array.Sort(ch1);
            string val1 = new string(ch);
            string val2 = new string(ch1);
            Console.WriteLine(val1.Equals(val2) ? "yes" : "no"); //ternary operator or Equals Method
            //By using == operator
            if (val1 == val2) 
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            
        }
        
    }
    class StringAnagram
    {

        static void Main(string[] args)
        {

            Anagram a1 = new Anagram();
           
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            a1.Check(s1, s2);
            Console.ReadKey();
        }
    }
}
