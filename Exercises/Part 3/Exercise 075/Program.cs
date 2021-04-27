﻿using System;
using System.Collections.Generic;

namespace exercise_75
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


            // Example method calls for testing your method.
            // List<int> numbers = new List<int>();
            // numbers.Add(5);

            Console.WriteLine("The numbers in the range [0, 5]");
            PrintNumbersInRange(list, 0, 5);

            Console.WriteLine("The numbers in the range [3, 10]");
            PrintNumbersInRange(list, 3, 10);
        }

        public static void PrintNumbersInRange(List<int> number, int low, int high)
        {
            int num = number.Count;
            
            for (int count = 0; count < num; count++)
            {
                if (number[count] >= low && number[count] <= high) { Console.WriteLine(number[count]); }
            }

        }

    }
}

