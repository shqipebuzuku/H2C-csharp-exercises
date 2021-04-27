﻿using System;
using System.Collections.Generic;

namespace exercise_73
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>();
            while (true)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == -1)
                {
                    break;
                }
                list.Add(input);
            }
            int num = list.Count;
            
            int sum = 0;
            
            for (int count = 0;count < num; count++) 
            {
                sum = sum + list[count];
            }
            Console.WriteLine("Sum: " + sum);

        }
    }
}
