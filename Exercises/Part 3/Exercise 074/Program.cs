using System;
using System.Collections.Generic;

namespace exercise_74
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
            Console.WriteLine("Search for?");
            string name = Console.ReadLine();
            int num = list.Count;
            int flag = 0;
            for (int count = 0; count < num; count++)
            {
                if(name == list[count]) { flag = 1; }
            }
            if (flag == 1) { Console.WriteLine(name + " was found!"); }
            if (flag == 0) { Console.WriteLine(name + " was not found!"); }
        }
    }
}

