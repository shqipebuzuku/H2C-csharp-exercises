using System;
using System.Collections.Generic;

namespace exercise_77
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<string> list = new List<string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }
                list.Add(input);
            }
            RemoveLast(list);
            list.ForEach(Console.WriteLine);
        }

        public static void RemoveLast(List<string> list)
        {
            int num = list.Count;

            list.RemoveAt(num - 1);
            
        }

    }
}


