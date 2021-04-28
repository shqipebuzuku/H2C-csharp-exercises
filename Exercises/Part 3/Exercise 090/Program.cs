using System;
using System.Collections.Generic;

namespace exercise_90
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

            int num = list.Count;
            int maxage = 0;
            for (int count =0;count<num;count++)
            {
                string[] sep = list[count].Split(",");
                int age = Convert.ToInt32(sep[1]);
                if (age >= maxage) { maxage = age; }
            }
            Console.WriteLine("The age of the oldest: " + maxage);
        }
    }
}



