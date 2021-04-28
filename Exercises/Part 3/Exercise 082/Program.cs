using System;
using System.Collections.Generic;

namespace exercise_82
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 5, 1, 3, 4, 2 };
            PrintArrayInStars(numbers);
            

        }

        public static void PrintArrayInStars(int[] numbers)
        {
            
            int num = numbers.Length;
            for (int count = 0; count < num; count++)
            {
                string p = "";
                for (int count2 = 0; count2 < numbers[count]; count2++)
                {
                    p = p + "*";
                }

                Console.WriteLine(p);
            }
            
        }

    }
}

