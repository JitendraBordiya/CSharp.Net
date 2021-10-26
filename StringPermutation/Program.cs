using System;

namespace StringPermutation
{
    class Program
    {
        public static void PowerSet(string s, int i, string cur)
        {
            try
            {
                int n = s.Length;
                if (i == n)
                {
                    Console.WriteLine(cur);
                    return;
                }
                PowerSet(s, i + 1, cur + s[i]);
                PowerSet(s, i + 1, cur);


            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
        }
        static void Main()
        {
            string str = "abc";
            int index = 0;
            string curr = "";
            Program.PowerSet(str, index, curr);
        }
    }
}
