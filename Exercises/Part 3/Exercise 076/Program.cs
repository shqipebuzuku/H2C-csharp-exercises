using System;
using System.Collections.Generic;

namespace exercise_76
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

            Console.WriteLine(SumNumbers(list));
            
        }

        public static int SumNumbers(List<int> number)
        {
            int num = number.Count;
            int sum = 0;
            for (int count = 0; count < num; count++)
            {
                sum = sum + number[count];
            }
            return sum;
        }

    }
}


