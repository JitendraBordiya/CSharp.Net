using System;

namespace DemoCharPalindrome
{
    class Palindrome{
        public void Onemethod( string name)
        {
            int length = name.Length;
            Boolean isArrayEqual = true;
            char[] oArray =name.ToCharArray();
            char[] copyArr=new char [oArray.Length];
            Array.Copy(oArray, copyArr, oArray.Length);
            //Array.Reverse(copyArr);
            for (int i = 0; i < length / 2; i++)
            {
                char temp = copyArr[i];
                copyArr[i] = copyArr[length - i - 1];
                copyArr[length - i - 1] = temp;
            }
            
            isArrayEqual = oArray.Equals(copyArr);
            if(oArray==copyArr)
            {
                
                Console.WriteLine("The String is a Palindrome");
            }
            else
            {
                Console.WriteLine(oArray);
                Console.WriteLine(copyArr);
                Console.WriteLine("The String is Not a Palindrome");
            }
        
            Console.WriteLine("Original Array");
            for(int i = 0; i < oArray.Length; i++)
            {
                Console.WriteLine(oArray[i]);
            }
            Console.WriteLine("Copy Array");
            for (int i = 0; i < copyArr.Length; i++)
            { 
                    Console.WriteLine(copyArr[i]);
            }
            

        }
        public void Secondmethod(string name)
        {
            char[] ch = name.ToCharArray();
            Array.Reverse(ch);
            String output = new string(ch);
            if (name.Equals(output))
            {
                Console.WriteLine("The String is a Palindrome");
            }
            else
            {
                Console.WriteLine("The String is not a Palindrome");
            }

        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Palindrome p = new Palindrome();
            Console.Write("Enter a String : ");
            string name = Console.ReadLine();
            //p.Onemethod(name);
            p.Secondmethod(name);
        }
    }
}
