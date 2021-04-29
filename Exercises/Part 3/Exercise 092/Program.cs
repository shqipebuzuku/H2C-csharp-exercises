using System;
using System.Collections.Generic;

namespace exercise_92
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
            string name = "";
            string longname = "";
            int maxage = 0;
            for (int count =0;count<num;count++)
            {
                string[] sep = list[count].Split(",");
                int age = 2020-Convert.ToInt32(sep[1]);
                name = sep[0];
                if (name.Length >= longname.Length) { longname = name; }
                if (age >= maxage) { maxage = age;  }
            }
            Console.WriteLine("Longest name: " + longname);
            Console.WriteLine("Highest age: " + maxage);
        }
    }
}



