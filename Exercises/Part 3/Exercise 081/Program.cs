using System;
using System.Collections.Generic;

namespace exercise_81
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 5, 1, 3, 4, 2 };
            PrintNeatly(numbers);
            

        }

        public static void PrintNeatly(int[] numbers)
        {
            string p="";
            int num = numbers.Length;
            for (int count = 0; count < num; count++)
            {
                 p = p + Convert.ToString(numbers[count]);
                if(count < num - 1) { p = p + ", "; }
            }
            Console.WriteLine(p);
        }

    }
}

