using System;
using System.Collections.Generic;

namespace exercise_86
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }
                string[] list = input.Split(" ");
                int num = list.Length;
                for (int count = 0; count < num; count++) { Console.WriteLine(list[count]); }
            }

        }
    }
}

