﻿using System;
using System.Collections.Generic;

namespace exercise_88
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
                Console.WriteLine(list[0]);
            }

        }
    }
}



