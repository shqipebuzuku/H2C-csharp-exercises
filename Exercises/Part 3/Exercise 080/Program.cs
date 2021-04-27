﻿using System;
using System.Collections.Generic;

namespace exercise_80
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 5, 1, 3, 4, 2 };
            int sum = SumOfNumbersInArray(numbers);
            Console.WriteLine(sum);

        }

        public static int SumOfNumbersInArray(int[] numbers)
        {
            int sum = 0;
            int num = numbers.Length;
            for (int count = 0; count < num; count++)
            {
                sum = sum + numbers[count];
            }
            return sum;
        }

    }
}


