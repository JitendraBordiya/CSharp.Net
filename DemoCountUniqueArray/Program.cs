using System;

namespace DemoCountUniqueArray
{
    class UniqueCount
    {
        public void Count(int[] arr)
        {
            int temp = 0;
            int unique = 0;
            
           
            bool[] visited =new bool[arr.Length] ;
            Console.WriteLine("UniqueElement"+"\t"+"unique");
            for (int i = 0; i < arr.Length;i++)
           {
                 temp = 1;
                if (visited[i] == true)
                {
                    continue;
                }
                for (int j =i+1; j < arr.Length; j++)
                {
                   
                    if (arr[i] == arr[j])
                    {
                        visited[j] = true;
                       
                        temp++;
                     }

                     }
                

                if (temp == 1)
                {
                    unique++;
                    
                }
                Console.WriteLine(arr[i] + "     \t    " + temp);
            }
           Console.WriteLine("\n Total number of unique elements found in array:"+unique);

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            UniqueCount r1 = new UniqueCount();
            Console.Write("Enter The Size of Array : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter Elements in Array");
            for(int i = 0; i<n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            r1.Count(arr);
        }
    }
}
