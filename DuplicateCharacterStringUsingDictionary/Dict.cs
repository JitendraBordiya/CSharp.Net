using System;
using System.Collections.Generic;


namespace DuplicateCharacterStringUsingDictionary
{
    public class Find{
        public static void FindDuplicate(string str)
        {
            string v = str.ToLower();
            var arr = v.ToCharArray();
            Dictionary<char, int> map = new Dictionary<char, int>();
            foreach (char ch in arr)
            {
                if (map.ContainsKey(ch))
                {
                    map[ch] = map[ch] + 1;
                }
                else
                {
                    map.Add(ch, 1);
                }
            }
            var keys = new HashSet<char>(map.Keys);
            foreach (char ch in keys)
            {
                if (map[ch] > 1)
                {
                    Console.WriteLine($"Character {ch} repeating {map[ch]} times.");
                }
            }


        }
        public Find()
        {
            Console.WriteLine("I am Constructor");
        }
        public void Grant()
        {
            var queue = new Queue<string>();
            queue.Enqueue("Apple");
            queue.Enqueue("Mango");
            queue.Enqueue("Banana");
            queue.Enqueue("Papaya");
            foreach(string s in queue)
            {
                Console.WriteLine($"Fruit : {s}");
            }

        }
    }
    class Dict
    {
        static void Main(string[] args)
        {
            string s1 = "JAVA OOPS COLLECTION ABSTRACTION INHERITANCE";
            Find.FindDuplicate(s1);
            Find f1 = new Find();
            f1.Grant();

        }
    }
}
